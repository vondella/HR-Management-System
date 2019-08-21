using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace HR_Management_System.Pages
{
    public class Make_a_cvModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;

        public Make_a_cvModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }


        public IActionResult OnGet()
        {
            if(_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Career)
            {
                return RedirectToPage("./Career_Login");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
            return Page();
        }




        public async Task<IActionResult> OnPostAsync(string title, string first_name, string last_name, string father_name, string mother_name,
           string present_address, string permanent_address, IFormFile profile_img, string phone_number, string mobile_number,
           DateTime date_of_birth, string gender, string marritual_status, string national_id, string religion, string nationality,
           string email, string[] qualification, string[] passing_year, string[] subject, string[] grade, string[] university,
           string[] company_name, DateTime?[] duration_from, string[] company_address, DateTime?[] duration_to, string[] role)
        {
            
            UserModel user = null;
            user = _db.Users.Include(a => a.Resume).Include(a => a.Resume.Experiences).Include(a => a.Resume.EducationalDetails).Single(aa => aa.Id == _accountManage.User.Id);
            if (user == null)
            {
                return NotFound();
            }

            Resume resume = new Resume();
            resume.Title = title;
            resume.FirstName = first_name;
            resume.LastName = last_name;
            resume.DateOfBirth = date_of_birth;
            

            List<string> qualifications = new List<string>();

            foreach(var item in qualification)
            {
                if(item != "" && item != null)
                {
                    qualifications.Add(item);
                }
            }

            List<string> Subjects = new List<string>();

            foreach(var item in subject)
            {
                Subjects.Add(item);
            }

            List<string> Institutes = new List<string>();

            foreach(var item in university)
            {
                Institutes.Add(item);
            }

            List<string> passing_years = new List<string>();

            foreach(var item in passing_year)
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


            if (qualifications.Count > 0)
            {
                resume.EducationalDetails = new List<DegreeDetails>();

                for (int i = 0; i < qualifications.Count; i++)
                {
                    var degree = new DegreeDetails();
                    degree.Grade = resutls[i];
                    degree.Institute = Institutes[i];
                    degree.PassingYear = passing_years[i];
                    degree.Qualification = qualifications[i];
                    degree.Subject = Subjects[i];
                    resume.EducationalDetails.Add(degree);
                }
            }


            resume.Email = email;
            

            if(company_names.Count > 0)
            {
                resume.Experiences = new List<ProfessionalExperience>();
                for(int i = 0; i < company_names.Count; i++)
                {
                    var experience = new ProfessionalExperience();
                    experience.CompanyAddress = company_addresses[i];
                    experience.CompanyName = company_names[i];
                    experience.DurationFrom = duration_froms[i];
                    experience.DurationTo = duration_tos[i];
                    experience.Role = roles[i];
                    resume.Experiences.Add(experience);
                }
            }

            resume.FatherName = father_name;
            resume.Gender = gender;
            resume.MarritualStatus = marritual_status;
            resume.MobileNumber = mobile_number;
            resume.MotherName = mother_name;
            resume.NationalID = national_id;
            resume.Nationality = nationality;
            resume.PermanentAddress = permanent_address;
            resume.PhoneNumber = phone_number;
            resume.PresentAddress = present_address;

            if (profile_img != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await profile_img.CopyToAsync(memoryStream);
                    resume.ProfileImage = memoryStream.ToArray();
                    user.ProfileImage = memoryStream.ToArray();
                    _accountManage.User.ProfileImage = memoryStream.ToArray();
                    _accountManage.User.ProfileImageSrc = _accountManage.ImgSrc(_accountManage.User.ProfileImage);
                }
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream();
                var current_directory = Directory.GetCurrentDirectory();
                FileStream fileStream = new FileStream($"{current_directory}/wwwroot/img/user.png", FileMode.Open);
                await fileStream.CopyToAsync(memoryStream);
                resume.ProfileImage = memoryStream.ToArray();
                user.ProfileImage = memoryStream.ToArray();
                _accountManage.User.ProfileImage = memoryStream.ToArray();
                _accountManage.User.ProfileImageSrc = _accountManage.ImgSrc(_accountManage.User.ProfileImage);
            }

            resume.Religion = religion;
            
            user.Resume = resume;

            await _db.SaveChangesAsync();

            var us = _db.Users.Include(u => u.Resume).SingleOrDefault(u => u.Id == _accountManage.User.Id);

            return RedirectToPage("./ViewCV", new {id = us.Resume.Id });
        }
    }
}