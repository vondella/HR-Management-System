using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.AdminPages.Recruitment
{
    public class ViewApplicantDetailsModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public ViewApplicantDetailsModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public Resume Resume { get; set; }

        public UserModel Career_user { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            UserModel career_user = null;
            try
            {
                career_user = await _db.Users.Include(a => a.Resume).SingleAsync(a => a.Id == id);
            }
            catch
            {
                return NotFound();
            }

            if(career_user == null)
            {
                return NotFound();
            }
            Career_user = career_user;
            Resume = await _db.Resumes.Include(a => a.Experiences).Include(a => a.EducationalDetails).SingleAsync(a => a.Id == career_user.Resume.Id);

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





        public async Task<IActionResult> OnGetDelete(long id)
        {
            UserModel career_user = null;
            career_user = await _db.Users.FindAsync(id);
            if(career_user == null)
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