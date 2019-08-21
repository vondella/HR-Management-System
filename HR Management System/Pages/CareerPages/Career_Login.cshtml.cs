using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace HR_Management_System.Pages
{
    public class Career_LoginModel : PageModel
    {

        private readonly HRMS_DB_Context _db;
        public AccountManageModel AccountManage { get; set; }


        public Career_LoginModel(HRMS_DB_Context context, AccountManageModel accountManage)
        {
            _db = context;
            AccountManage = accountManage;
        }

      
        
        public long UserId { get; set; }


        public bool AuthenticationFailed { get; set; } = false;


        [BindProperty]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public void OnGet()
        {
            
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var _user = _db.Users.Where(a => a.UserType == UserType.Career && a.Email.ToLower() == EmailAddress.ToLower()).AsNoTracking().ToList().SingleOrDefault();

                if (_user == null)
                {
                    AuthenticationFailed = true;
                    return Page();
                }

                if (Password == _user.Password)
                {
                    AuthenticationFailed = false;
                    AccountManage.IsLoggedIn = true;

                    AccountManage.User = new UserModel
                    {
                        Email = _user.Email,
                        Id = _user.Id,
                        Name = _user.Name,
                        UserType = UserType.Career,
                        Password = _user.Password,
                        UserName = _user.UserName
                    };

                    AccountManage.User.ProfileImageSrc = AccountManage.ImgSrc(_user.ProfileImage);







                    return RedirectToPage("/CareerPages/Career_Dashboard");
                }
                else
                {
                    AuthenticationFailed = true;
                    return Page();
                }
            }
            else
            {
                AuthenticationFailed = false;
                return Page();
            }
        }
    }
}