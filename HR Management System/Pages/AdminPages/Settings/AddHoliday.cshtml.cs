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
    public class AddHolidayModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        [BindProperty]
        public HolidayModel Holiday { get; set; }


        public AddHolidayModel(HRMS_DB_Context db)
        {
            _db = db;
        }


        public void OnGet()
        {

        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Holidays.Add(Holiday);
                await _db.SaveChangesAsync();
                return RedirectToPage("/AdminPages/Settings/HolidayList");
            }

            return RedirectToPage();
        }



    }
}