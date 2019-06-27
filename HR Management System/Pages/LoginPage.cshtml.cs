using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages
{
    public class LoginPageModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private MyDependency _dependency;

        public LoginPageModel(HRMS_DB_Context context, MyDependency myDependency)
        {
            _db = context;
            _dependency = myDependency;
        }

        public List<UserModel> Users { get; set; }

       
        [BindProperty]
        public string SimpleMessage { get; set; }



        //public long Id { get; set; }

        //public string Name { get; set; }
        [BindProperty]
        [Required]
        public string UserName { get; set; }
      
        //[EmailAddress]
        //public string Email { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Display(Name = "Remember me?")]
        //public bool RememberMe { get; set; }


        public void OnGet()
        {
            var yes = _db.Users.Any();
            SimpleMessage = _dependency.GetMessage();
        }

        public IActionResult OnPostAsync()
        {
            var _user = _db.Users.Where( a => a.UserName == UserName).ToList().SingleOrDefault();

            if(_user == null)
            {
                return Page();
            }

            if(Password == _user.Password)
            {
                return RedirectToPage("/Dashboard");
            }
            else
            {
                return Page();
            }
        }
    }
}