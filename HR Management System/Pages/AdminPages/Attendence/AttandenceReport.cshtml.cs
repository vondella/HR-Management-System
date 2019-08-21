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
    public class AttandenceReportModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public AttandenceReportModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public int TotalDays { get; set; }

        public List<EmployeeAttendanceViewModel> EmployeeAttendanceViews { get; set; }


        public async Task<IActionResult> OnGetAsync(DateTime? dateTime)
        {

            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            EmployeeAttendanceViews = new List<EmployeeAttendanceViewModel>();

            if(dateTime != null)
            {
                var searchDateMonth = (DateTime)dateTime;
                var today = DateTime.Today;
                TotalDays = DateTime.DaysInMonth(today.Year, today.Month);

                var employess = await _db.Users.Where(a => a.UserType == UserType.Employee && a.Status == true && a.JoiningDate != null).Include(a => a.Attendances).AsNoTracking().ToListAsync();

                var startMonthDate = new DateTime(searchDateMonth.Year, searchDateMonth.Month, 1);
                var endMonthDate = new DateTime(searchDateMonth.Year, searchDateMonth.Month, TotalDays);


                if (employess != null)
                {
                    if (employess.Count > 0)
                    {
                        foreach (var emp in employess)
                        {

                            if (((DateTime)emp.JoiningDate).CompareTo(endMonthDate) <= 0)
                            {
                                var empVM = new EmployeeAttendanceViewModel();
                                empVM.Attendances = new List<Attendance>();
                                empVM.Name = emp.Name;
                                if (emp.Attendances.Count > 0)
                                {
                                    for (int i = 0; i < TotalDays; i++)
                                    {
                                        var specificDay = new DateTime(startMonthDate.Year, startMonthDate.Month, i + 1);
                                        if (((DateTime)emp.JoiningDate).CompareTo(specificDay) > 0)
                                        {
                                            empVM.Attendances.Add(new Attendance { Status = AttendanceStatus.NotJoined });
                                        }
                                        else
                                        {
                                            var att = emp.Attendances.SingleOrDefault(a => a.Day == i + 1 && a.Month == startMonthDate.Month && a.Year == startMonthDate.Year);
                                            if (att != null)
                                            {
                                                empVM.Attendances.Add(new Attendance { Status = att.Status });
                                            }
                                            else
                                            {
                                                empVM.Attendances.Add(new Attendance { Status = AttendanceStatus.NotJoined });
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for(int i = 0; i < TotalDays; i++)
                                    {
                                        empVM.Attendances.Add(new Attendance { Status = AttendanceStatus.NotJoined });
                                    }
                                    
                                }
                                EmployeeAttendanceViews.Add(empVM);
                            }

                        }
                    }
                    
                }
            }
            else
            {
                TotalDays = 0;
            }

            
            return Page();
        }
    }
}