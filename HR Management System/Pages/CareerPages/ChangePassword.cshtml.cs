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
    public class ChangePasswordModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;




        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [BindProperty]
        [DataType(DataType.Password)]
        [Required]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [BindProperty]
        public string NewPassword2 { get; set; }



        public bool OldPasswordDidntMatch { get; set; } = false;
        public bool NewPasswordDidntMatch { get; set; } = false;






        public ChangePasswordModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public IActionResult OnGet()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Career)
            {
                return RedirectToPage("./Career_Login");
            }

            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
            return Page();
        }








        public async Task<IActionResult> OnPostChangePassword()
        {
            OldPasswordDidntMatch = false;
            NewPasswordDidntMatch = false;

            if (_accountManage.User.Password == OldPassword)
            {
                if (NewPassword != "" && NewPassword2 != "" && NewPassword != null && NewPassword2 != null)
                {
                    if (NewPassword == NewPassword2)
                    {
                        var user = await _db.Users.FindAsync(_accountManage.User.Id);
                        user.Password = NewPassword;
                        _accountManage.User.Password = NewPassword;
                        await _db.SaveChangesAsync();
                        return RedirectToPage();
                    }
                    else
                    {
                        NewPasswordDidntMatch = true;
                        ViewData["User_Name"] = _accountManage.User.Name;
                        return Page();
                    }
                }
                else
                {
                    ViewData["User_Name"] = _accountManage.User.Name;
                    return Page();
                }
            }
            else
            {
                OldPasswordDidntMatch = true;
                ViewData["User_Name"] = _accountManage.User.Name;
                return Page();
            }
        }
    }
}