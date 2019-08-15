using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages
{
    public class LeaveCategoryModel : PageModel
    {
        private readonly HRMS_DB_Context _db;


        [BindProperty]
        public List<LeaveCategory> LeaveCategories { get; set; }


        public LeaveCategoryModel(HRMS_DB_Context db)
        {
            _db = db;
        }



        public void OnGet()
        {
            if (_db.LeaveCategories.Any())
            {
                LeaveCategories = _db.LeaveCategories.AsNoTracking().ToList();
            }
        }



        public async Task<IActionResult> OnGetDelete(long id)
        {
            var ff = await _db.LeaveCategories.FindAsync(id);
            _db.LeaveCategories.Remove(ff);
            await _db.SaveChangesAsync();
            return RedirectToPage();
        }



        public IActionResult OnGetEdit(long id)
        {
            return RedirectToPage("./EditLeaveCategory", new { id = id});
        }
    }
}