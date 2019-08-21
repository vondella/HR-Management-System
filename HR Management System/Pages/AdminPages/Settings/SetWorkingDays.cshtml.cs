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
        private readonly AccountManageModel _accountManage;


        public SetWorkingDaysModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }

        public IActionResult OnGet(bool? saved)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);


            Days = _db.WeekDays.ToList();

            if (saved != null)
            {
                Saved = (bool)saved;
            }
            else Saved = false;

            return Page();
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