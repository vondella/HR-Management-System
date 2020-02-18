using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using System.ComponentModel.DataAnnotations;

namespace HR_Management_System.Pages.CareerPages
{
    public class RegisterModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;




        [BindProperty]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="First Name")]
        [BindProperty]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [BindProperty]
        [Required]
        public string LastName { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Passwword")]
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password2 { get; set; }






        public bool EmailExist { get; set; } = false;
        public bool PasswordDidntMatch { get; set; } = false;













        public RegisterModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }


        public void OnGet()
        {

        }


        





        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                UserModel exist_user = null;
                try
                {
                    exist_user = _db.Users.Single(u => u.Email.ToLower() == Email.ToLower());
                }
                catch(Exception ex)
                {

                }
                if(exist_user != null)
                {
                    EmailExist = true;
                    return Page();
                }

                if(Password != Password2)
                {
                    PasswordDidntMatch = true;
                    return Page();
                }

               
                var last_user = _db.Users.Last();

                exist_user = new UserModel
                {
                    Name = FirstName + " " + LastName,
                    Email = Email,
                    Password = Password,
                    UserType = UserType.Career,
                    UserName = "career" + last_user.Id
                };

                _db.Users.Add(exist_user);
                await _db.SaveChangesAsync();

                _accountManage.IsLoggedIn = true;
                _accountManage.User = exist_user;

                return RedirectToPage("/CareerPages/Career_Dashboard");
            }
            else
            {
                return Page();
            }
        }

    }
}