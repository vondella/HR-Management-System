using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages
{
    public class LoginPageModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;
        public LoginPageModel(HRMS_DB_Context context, AccountManageModel accountManage)
        {
            _db = context; _accountManage = accountManage;
        }



        public UserModel User { get; set; }

        public bool WrongUsername { get; set; } = false;

        public bool WrongPassword { get; set; } = false;


        [BindProperty]
        [Required]
        public string UserName { get; set; }
      
        //[EmailAddress]
        //public string Email { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

     


        public void OnGet()
        {
            
        }

        public IActionResult OnPostAsync()
        {

            try { User = _db.Users.Where(a => a.UserName == UserName.ToLower()).AsNoTracking().Single(); }
            catch { }

            if(User == null)
            {
                WrongUsername = true;
                WrongPassword = false;

                return Page();
            }


            if(Password == User.Password)
            {
                ViewData.Add("User_Name", (string)User.Name);

                if (User.UserType == UserType.Admin)
                {
                    _accountManage.IsLoggedIn = true;
                    _accountManage.User = User;
                    return RedirectToPage("/AdminPages/AdminDashboard");
                }
                if (User.UserType ==  UserType.Employee)
                {
                    _accountManage.IsLoggedIn = true;
                    _accountManage.User = User;
                    return RedirectToPage("/EmployeePages/Employee_Dashboard");
                }
            }
            WrongUsername = false;
            WrongPassword = true;
            return Page();
        }
    }
}