using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.CareerPages
{
    public class ViewCVModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public ViewCVModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }


        public Resume Resume { get; set; }

        public IActionResult OnGet(long? id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Career)
            {
                return RedirectToPage("./Career_Login");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
            if (id == null)
            {
                Resume = null;
                return Page();
            }


            try
            {
                Resume = _db.Resumes.Include(a => a.EducationalDetails).Include(a => a.Experiences).Single(i => i.Id == (long)id);
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
            if(gg != null)
            {
                var fd = (DateTime)gg;
                return fd.ToShortDateString();
            }
            return "";
        }
    }
}