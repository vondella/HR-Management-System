using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages.EmployeePages
{
    public class profileModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        public readonly AccountManageModel _accountManage;

        public profileModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }




        [BindProperty]
        [Required]
        public string Name { get; set; }





        public IActionResult OnGet()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Employee || _accountManage.User.Status != true)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
            Name = _accountManage.User.Name;
            return Page();
        }






        public async Task<IActionResult> OnPostUpdateProfileData()
        {
            if (Name != null && Name != "")
            {
               
                var user = await _db.Users.FindAsync(_accountManage.User.Id);
                user.Name = Name;
                await _db.SaveChangesAsync();
                _accountManage.User.Name = Name;
                return RedirectToPage();
            }
            return Page();
        }

    }
}