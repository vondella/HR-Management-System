using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace HR_Management_System.Pages
{
    public class Update_cvModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;


        //[BindProperty]
        public Resume Resume { get; set; }

        public Update_cvModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public IActionResult OnGet(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Career)
            {
                return RedirectToPage("./Career_Login");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            Resume = _db.Resumes.Include(a=> a.EducationalDetails).Include(a=>a.Experiences).Single(i=>i.Id == id);
            if(Resume == null)
            {
                return NotFound();
            }
            return Page();
        }



        public string ImgSrc(byte[] img_data)
        {
            try
            {
                var base64 = Convert.ToBase64String(img_data);
                var imgSrc = String.Format("data:image/jpg;base64,{0}", base64);
                return imgSrc;
            }
            catch
            {
                return "~/img/user.png";
            }

        }


        public string BirthdayString(DateTime? gg)
        {
            if (gg != null)
            {
                var fd = (DateTime)gg;
                return fd.ToShortDateString();
            }
            return "";
        }




        public async Task<IActionResult> OnPostAsync(long id, string title, string first_name, string last_name, string father_name, string mother_name,
          string present_address, string permanent_address, IFormFile profile_img, string phone_number, string mobile_number,
          DateTime date_of_birth, string gender, string marritual_status, string national_id, string religion, string nationality,
          string email, string[] qualification, string[] passing_year, string[] subject, string[] grade, string[] university,
          string[] company_name, DateTime?[] duration_from, string[] company_address, DateTime?[] duration_to, string[] role)
        {

            Resume = _db.Resumes.Include(a => a.EducationalDetails).Include(a => a.Experiences).Single(i => i.Id == id);
            if (Resume == null)
            {
                return NotFound();
            }

            Resume.Title = title;
            Resume.FirstName = first_name;
            Resume.LastName = last_name;
            Resume.DateOfBirth = date_of_birth;


            List<string> qualifications = new List<string>();

            foreach (var item in qualification)
            {
                if (item != "" && item != null)
                {
                    qualifications.Add(item);
                }
            }

            List<string> Subjects = new List<string>();

            foreach (var item in subject)
            {
                Subjects.Add(item);
            }

            List<string> Institutes = new List<string>();

            foreach (var item in university)
            {
                Institutes.Add(item);
            }

            List<string> passing_years = new List<string>();

            foreach (var item in passing_year)
            {
                passing_years.Add(item);
            }


            List<string> resutls = new List<string>();

            foreach (var item in grade)
            {
                resutls.Add(item);
            }


            List<string> company_names = new List<string>();

            foreach (var item in company_name)
            {
                if (item != null && item != "")
                {
                    company_names.Add(item);
                }
            }


            List<string> company_addresses = new List<string>();

            foreach (var item in company_address)
            {
                company_addresses.Add(item);
            }


            List<string> roles = new List<string>();

            foreach (var item in role)
            {
                roles.Add(item);
            }


            List<DateTime?> duration_froms = new List<DateTime?>();

            foreach (var item in duration_from)
            {
                duration_froms.Add(item);
            }

            List<DateTime?> duration_tos = new List<DateTime?>();

            foreach (var item in duration_to)
            {
                duration_tos.Add(item);
            }

            if (Resume.EducationalDetails == null)
            {
                Resume.EducationalDetails = new List<DegreeDetails>();
            }

            Resume.EducationalDetails.Clear();

            if (qualifications.Count > 0)
            {
                

                for (int i = 0; i < qualifications.Count; i++)
                {
                    var degree = new DegreeDetails();
                    degree.Grade = resutls[i];
                    degree.Institute = Institutes[i];
                    degree.PassingYear = passing_years[i];
                    degree.Qualification = qualifications[i];
                    degree.Subject = Subjects[i];
                    
                    Resume.EducationalDetails.Add(degree);
                }
            }


            Resume.Email = email;

            if (Resume.Experiences == null)
            {
                Resume.Experiences = new List<ProfessionalExperience>();
            }

            Resume.Experiences.Clear();

            if (company_names.Count > 0)
            {
                Resume.Experiences = new List<ProfessionalExperience>();
                for (int i = 0; i < company_names.Count; i++)
                {
                    var experience = new ProfessionalExperience();
                    experience.CompanyAddress = company_addresses[i];
                    experience.CompanyName = company_names[i];
                    experience.DurationFrom = duration_froms[i];
                    experience.DurationTo = duration_tos[i];
                    experience.Role = roles[i];
                    Resume.Experiences.Add(experience);
                }
            }

            Resume.FatherName = father_name;
            Resume.Gender = gender;
            Resume.MarritualStatus = marritual_status;
            Resume.MobileNumber = mobile_number;
            Resume.MotherName = mother_name;
            Resume.NationalID = national_id;
            Resume.Nationality = nationality;
            Resume.PermanentAddress = permanent_address;
            Resume.PhoneNumber = phone_number;
            Resume.PresentAddress = present_address;

            if (profile_img != null)
            {
                var user = await _db.Users.FindAsync(_accountManage.User.Id);

                using (var memoryStream = new MemoryStream())
                {
                    await profile_img.CopyToAsync(memoryStream);
                    Resume.ProfileImage = memoryStream.ToArray();
                    user.ProfileImage = memoryStream.ToArray();
                    _accountManage.User.ProfileImage = memoryStream.ToArray();
                    _accountManage.User.ProfileImageSrc = _accountManage.ImgSrc(_accountManage.User.ProfileImage);
                }
            }
         

            Resume.Religion = religion;
           

            await _db.SaveChangesAsync();

           
            return RedirectToPage("./ViewCV", new { id = id });
        }
    }
}