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
    public class EditHolidayModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        [BindProperty]
        public HolidayModel Holiday { get; set; }


        public EditHolidayModel(HRMS_DB_Context db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            var holiday = await _db.Holidays.FindAsync(id);
            if(holiday == null)
            {
                return NotFound();
            }
            Holiday = holiday;

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            var holiday = await _db.Holidays.FindAsync(Holiday.Id);
            if(holiday == null)
            {
                return NotFound();
            }
            holiday.Description = Holiday.Description;
            holiday.Name = Holiday.Name;
            holiday.StartDate = Holiday.StartDate;
            holiday.EndDate = Holiday.EndDate;

            await _db.SaveChangesAsync();

            return RedirectToPage("./HolidayList");
        }

    }
}