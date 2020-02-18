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
    public class ProfileModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        public readonly AccountManageModel _accountManage;

        public ProfileModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        [BindProperty]
        public UserModel CareerUser { get; set; }


        [BindProperty]
        [Required]
        public string Name { get; set; }





       




        public IActionResult OnGet()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Career)
            {
                return RedirectToPage("./Career_Login");
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
                _accountManage.User.Name = Name;
                var user = await _db.Users.FindAsync(_accountManage.User.Id);
                user.Name = Name;
                await _db.SaveChangesAsync();
                return RedirectToPage();
            }
            return Page();
        }




      
    }
}