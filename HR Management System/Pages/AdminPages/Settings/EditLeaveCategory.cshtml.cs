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

        [BindProperty]
        public LeaveCategory LeaveCategory { get; set; }


        public EditLeaveCategoryModel(HRMS_DB_Context db)
        {
            _db = db;
        }


        public async void OnGetAsync(long id)
        {
            LeaveCategory = await _db.LeaveCategories.FindAsync(id);
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