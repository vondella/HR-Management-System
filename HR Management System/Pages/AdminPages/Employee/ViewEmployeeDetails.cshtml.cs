using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.AdminPages.Employee
{
    public class ViewEmployeeDetailsModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public ViewEmployeeDetailsModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public UserModel Employee { get; set; }

        public long? ResumeId { get; set; }

        public IActionResult OnGet(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);


            Employee = _db.Users.Include(s => s.Resume).Single(a => a.Id == id);

            if (Employee == null)
            {
                return NotFound();
            }

            if (Employee.Resume != null)
            {
                ResumeId = Employee.Resume.Id;
            }


            return Page();
        }


        public string IsActive(bool a)
        {
            if (a == true)
            {
                return "Active";
            }
            else return "Inactive";
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
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    var current_directory = Directory.GetCurrentDirectory();
                    FileStream fileStream = new FileStream($"{current_directory}/wwwroot/img/user.png", FileMode.Open);
                    fileStream.CopyTo(memoryStream);
                    var imgData = memoryStream.ToArray();
                    var base64 = Convert.ToBase64String(imgData);
                    var imgSrc = String.Format("data:image/jpg;base64,{0}", base64);
                    fileStream.Close();
                    return imgSrc;
                }
                
            }

        }
    }
}