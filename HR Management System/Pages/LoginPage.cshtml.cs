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
        private readonly HRMS_DB_Context _context;

        public LoginPageModel(HRMS_DB_Context context)
        {
            _context = context;
        }

        public List<UserModel> Users { get; set; }

        public UserModel User { get; set; }




        //public long Id { get; set; }

        //public string Name { get; set; }

        //[Required]
        //public string UserName { get; set; }
      
        //[EmailAddress]
        //public string Email { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[Display(Name = "Remember me?")]
        //public bool RememberMe { get; set; }


        public async Task OnGetAsync()
        {
            User = new UserModel();
        }

        public IActionResult OnPostAsync()
        {
            return Page();
        }
    }
}