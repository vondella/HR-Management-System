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
    public class HolidayListModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        public HolidayListModel(HRMS_DB_Context db)
        {
            _db = db;
        }

        [BindProperty]
        public List<HolidayModel> SortedHolidays { get; set; }

        [BindProperty]
        public DateTime? SortedMonth { get; set; }



        public void OnGet(DateTime? sort_date)
        {
            SortedMonth = sort_date;

            IQueryable<HolidayModel> IQHolidays = from hol in _db.Holidays
                                                  select hol;

            if(sort_date != null)
            {
                DateTime startDate = (DateTime)sort_date;
                IQHolidays = IQHolidays.Where(h => h.StartDate.Year == startDate.Year && h.StartDate.Month == startDate.Month);
            }

            SortedHolidays = IQHolidays.AsNoTracking().ToList();
        }






        public async Task<IActionResult> OnGetDeleteAsync(long id)
        {
            var holiday = await _db.Holidays.FindAsync(id);
            if(holiday == null)
            {
                return NotFound();
            }
            _db.Holidays.Remove(holiday);
            await _db.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}