using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;




namespace HR_Management_System.Pages.AdminPages.Settings
{
    public class AddLeaveCategoryModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;


        [BindProperty]
        public LeaveCategory LeaveCategory { get; set; }


        public AddLeaveCategoryModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }



        public IActionResult OnGet()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.LeaveCategories.Add(LeaveCategory);
                await _db.SaveChangesAsync();

                return RedirectToPage("./LeaveCategory");
            }
            return Page();
        }
    }
}