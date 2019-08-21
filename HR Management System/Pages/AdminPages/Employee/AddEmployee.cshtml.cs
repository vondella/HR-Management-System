using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages
{
    public class AddEmployeeModel : PageModel
    {

        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public AddEmployeeModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public Resume Resume { get; set; }

        public List<UserModel> Applicants { get; set; }

        public async Task<IActionResult> OnGetAsync(string src_string)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;

            Applicants = new List<UserModel>();

            var notices = await _db.RecruitementNotices.Include(a => a.Applicants).ToListAsync();

            if(notices != null)
            {
                foreach (var d in notices)
                {
                    if (d.Applicants.Count > 0)
                    {
                        foreach (var u in d.Applicants)
                        {
                            if (u.SelectedForInterview == true && u.UserType == UserType.Career)
                            {
                                var applicant = new UserModel
                                {
                                    Id = u.Id,
                                    DateOfApplication = u.DateOfApplication,
                                    Department = d.Department,
                                    Designation = d.Designation,
                                    Email = u.Email,
                                    InterviewDate = u.InterviewDate,
                                    Name = u.Name,
                                    SelectedForInterview = u.SelectedForInterview,
                                    UserType = u.UserType
                                };
                                Applicants.Add(applicant);
                            }
                        }
                    }
                }
            }

          

            
            if(src_string != null && src_string != "")
            {
                if(Applicants.Count > 0)
                {
                    Applicants = Applicants.Where(a => a.Name.IndexOf(src_string, StringComparison.CurrentCultureIgnoreCase) > -1).ToList();
                }
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




        public string DateOfApplcationShortForm(DateTime? datetime)
        {
            if (datetime != null)
            {
                var date = (DateTime)datetime;
                return date.ToString("MMMM dd, yyyy");
            }
            else
            {
                return "Not Defined";
            }
        }




        public async Task<IActionResult> OnGetDelete(long id)
        {
            UserModel career_user = null;
            career_user = await _db.Users.FindAsync(id);
            if (career_user == null)
            {
                return NotFound();
            }
            career_user.SelectedForInterview = false;
            career_user.InterviewDate = null;
            await _db.SaveChangesAsync();
            return RedirectToPage("./Selected_Applicant_List");
        }
    }
}