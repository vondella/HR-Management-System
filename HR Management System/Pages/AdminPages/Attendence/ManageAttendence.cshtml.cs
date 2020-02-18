using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages
{
    public class ManageAttendenceModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public ManageAttendenceModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public List<UserModel> SortedEmployees { get; set; }

        public bool TodayIsHoliDay { get; set; } = false;


        public async Task<IActionResult> OnGetAsync()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            var today = DateTime.Now;

            var weekdays = await _db.WeekDays.AsNoTracking().ToListAsync();
            
            var weekDay = weekdays.Where(a => a.Name == today.DayOfWeek.ToString()).Single();

            //if (weekDay.IsHoliday == true)
            //{
            //    TodayIsHoliDay = true;
            //    return Page();
            //}

            //var holiday = await  _db.Holidays.Where(a => a.StartDate.CompareTo(today) <= 0 && a.EndDate.CompareTo(today) >= 0).AsNoTracking().SingleOrDefaultAsync();

            //if(holiday != null)
            //{
            //    TodayIsHoliDay = true;
            //    return Page();
            //}


            SortedEmployees = new List<UserModel>();

            var Employees = await _db.Users.Include(a=>a.Attendances).Where(a => a.UserType == UserType.Employee && a.Status == true).AsNoTracking().ToListAsync();

            
            if(Employees != null)
            {
                if(Employees.Count > 0)
                {
                    foreach(var emp in Employees)
                    {
                        if(emp.JoiningDate != null)
                        {
                            if(((DateTime)emp.JoiningDate).CompareTo(DateTime.Now) <= 0)
                            {
                                SortedEmployees.Add(emp);
                                //Attendance att = null;
                                //try { att = emp.Attendances.Where(a => a.Day == today.Day && a.Month == today.Month && a.Year == today.Year).Single(); } catch { }
                                //if(att == null)
                                //{
                                    
                                //}
                            }
                        }
                    }
                }
            }

            return Page();
        }




        public string GiveStatus(Attendance attendance)
        {
            return attendance.Status.ToString();
        }
    }
}