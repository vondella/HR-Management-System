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
        [Required]
        public string Name { get; set; }



        [BindProperty]
        [Required]
        public string Username { get; set; }

        public bool UsernameExisted { get; set; } = false;




        public IActionResult OnGet()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
            Name = _accountManage.User.Name;
            Username = _accountManage.User.UserName;
            return Page();
        }






        public async Task<IActionResult> OnPostUpdateProfileData()
        {
            if (Name != null && Name != "" && Username != null && Username != "")
            {
                if(Username != _accountManage.User.UserName)
                {
                    var users = _db.Users.Where(a => a.UserName == Username).ToList();
                    if (users != null)
                    {
                        if (users.Count > 0)
                        {
                            UsernameExisted = true;
                            return Page();
                        }
                    }
                }
               



                var user = await _db.Users.FindAsync(_accountManage.User.Id);

                user.Name = Name;
                user.UserName = Username;
                await _db.SaveChangesAsync();
                _accountManage.User.Name = Name;
                _accountManage.User.UserName = Username;
                return RedirectToPage();
            }
            return Page();
        }



    }
}