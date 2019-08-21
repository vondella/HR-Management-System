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
    public class Applicant_detailsModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public Applicant_detailsModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }


        public Resume Resume { get; set; }

        public UserModel Career_user { get; set; }

        public IActionResult OnGet(long? id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;

            if (id == null)
            {
                Resume = null;
                return Page();
            }


            try
            {
                Career_user =  _db.Users.Include(a=>a.Resume).Single(a=>a.Id == id);
                Resume =  _db.Resumes.Include(a=>a.EducationalDetails).Include(a=>a.Experiences).Single(g=>g.Id ==  Career_user.Resume.Id);
            }
            catch
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







      
    }
}