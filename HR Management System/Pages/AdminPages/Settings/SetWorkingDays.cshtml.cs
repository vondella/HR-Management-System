using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages.AdminPages.Settings
{
    public class SetWorkingDaysModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        public SetWorkingDaysModel(HRMS_DB_Context db)
        {
            _db = db;
        }

        public void OnGet(bool? saved)
        {
            Days = _db.WeekDays.ToList();

            if (saved != null)
            {
                Saved = (bool)saved;
            }
            else Saved = false;
        }


        [BindProperty]
        public List<WeekDayModel> Days { get; set; }

        
        public bool Saved { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                foreach (var item in Days)
                {
                    var item_to_update = await _db.WeekDays.FindAsync(item.Id);
                    item_to_update.IsWorkingDay = item.IsWorkingDay;
                    await _db.SaveChangesAsync();
                }

                return RedirectToPage(new { saved = true });
            }
            return RedirectToPage();
        }



        public string IsHoidayReverse(bool isHoliday)
        {
            return (!isHoliday).ToString();
        }
    }
}