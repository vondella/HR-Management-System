using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.EmployeePages
{
    public class Remain_leaveModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public Remain_leaveModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }




        public List<LeaveCategoryRemainingDays> LeaveCategoryRemainingDaysCollection { get; set; }




        public async Task<IActionResult> OnGetAsync()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Employee)
            {
                return RedirectToPage("/LoginPage");
            }


            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);



            LeaveCategoryRemainingDaysCollection = new List<LeaveCategoryRemainingDays>();

            if (_db.LeaveCategories.Any())
            {
                var leaveCategories = await _db.LeaveCategories.AsNoTracking().ToListAsync();
                var leaveApplications = await _db.LeaveApplications.Include(a => a.LeaveCategory).Include(a => a.User).Where(a => a.User.Id == _accountManage.User.Id).AsNoTracking().ToListAsync();

                foreach (var item in leaveCategories)
                {
                    var leaveCategoryRemainingDays = new LeaveCategoryRemainingDays();
                    leaveCategoryRemainingDays.CategoryName = item.Title;
                    leaveCategoryRemainingDays.TotalDays = item.Days;
                    if(leaveApplications != null)
                    {
                        if(leaveApplications.Count > 0)
                        {
                            foreach (var app_item in leaveApplications)
                            {
                                if (app_item.LeaveCategory.Id == item.Id)
                                {
                                    if (app_item.Status == LeaveApplicationStatus.Approved)
                                    {
                                        leaveCategoryRemainingDays.UsedDays += app_item.Days;
                                    }
                                }
                            }
                        }
                    }
                    
                    LeaveCategoryRemainingDaysCollection.Add(leaveCategoryRemainingDays);
                }
            }

            




            return Page();
        }





        public int RemainingDays(int total_days, int used_days)
        {
            var remaining_days = total_days - used_days;

            if (remaining_days < 0)
            {
                return 0;
            }
            else return remaining_days;
        }
    }
}