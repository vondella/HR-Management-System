using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages
{
    public class Career_LoginModel : PageModel
    {

        private readonly HRMS_DB_Context _db;

        public Career_LoginModel(HRMS_DB_Context context)
        {
            _db = context;
        }

      
        public long UserId { get; set; }


        [BindProperty]
        [Required]
        public string UserName { get; set; }


        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public void OnGet()
        {
            var user = _db.CareerUsers.SingleOrDefault();
            UserId = user.Id;
        }


        public IActionResult OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var _user = _db.CareerUsers.Where(a => a.Username == UserName).ToList().SingleOrDefault();

            if (_user == null)
            {
                return Page();
            }

            if (Password == _user.Password)
            {
                return RedirectToPage("/Career_Dashboard");
            }
            else
            {
                return Page();
            }
        }
    }
}