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
        private readonly AccountManageModel _accountManage;

        public HolidayListModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }

        [BindProperty]
        public List<HolidayModel> SortedHolidays { get; set; }

        [BindProperty]
        public DateTime? SortedMonth { get; set; }



        public IActionResult OnGet(DateTime? sort_date)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            SortedMonth = sort_date;

            IQueryable<HolidayModel> IQHolidays = from hol in _db.Holidays
                                                  select hol;

            if(sort_date != null)
            {
                DateTime startDate = (DateTime)sort_date;
                IQHolidays = IQHolidays.Where(h => h.StartDate.Year == startDate.Year && h.StartDate.Month == startDate.Month);
            }

            SortedHolidays = IQHolidays.AsNoTracking().ToList();
            return Page();
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