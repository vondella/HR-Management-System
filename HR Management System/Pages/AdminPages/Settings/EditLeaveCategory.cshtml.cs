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
    public class EditLeaveCategoryModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        [BindProperty]
        public LeaveCategory LeaveCategory { get; set; }


        public EditLeaveCategoryModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }


        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
            LeaveCategory = await _db.LeaveCategories.FindAsync(id);
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
             var leave = await _db.LeaveCategories.FindAsync(LeaveCategory.Id);
            leave.Title = LeaveCategory.Title;
            leave.Days = LeaveCategory.Days;
            await _db.SaveChangesAsync();
            return RedirectToPage("./LeaveCategory");
        }
    }
}