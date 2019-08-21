using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Controllers
{
    public class EmpController : Controller
    {
        private readonly HRMS_DB_Context _db;
       

        public EmpController(HRMS_DB_Context db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return RedirectToPage("/EmployeePages/Employee_Dashboard");
        }
        public IActionResult Leave_Application()
        {
            return RedirectToPage("/EmployeePages/Leave_Application");
        }
        public IActionResult Notice()
        {
            return RedirectToPage("/EmployeePages/Notice");
        }
        public IActionResult payment_info()
        {
            return RedirectToPage("/EmployeePages/payment_info");
        }

        public IActionResult logout()
        {
            return RedirectToPage("/LoginPage");
        }
        public IActionResult Profile()
        {
            return RedirectToPage("/EmployeePages/Profile");
        }
        public IActionResult Apply_Leave()
        {
            return RedirectToPage("/EmployeePages/New_leave");
        }



        public async Task<string> ActivateOrDeactivateEmployeeAsync(long id)
        {
            var user = await _db.Users.FindAsync(id);
            if(user == null)
            {
                return "failed";
            }

            user.Status = !user.Status;
            await _db.SaveChangesAsync();

            if (user.Status == true)
            {
                return "active";
            }
            else return "deactive";
        }




        public async Task<string> PresentAbsentEmployeeAsync(long id, string status)
        {
            var user = await _db.Users.Include(a=>a.Attendances).SingleOrDefaultAsync(a=>a.Id == id);
            if (user == null)
            {
                return "failed";
            }

            var todat = DateTime.Now;

           if(user.Attendances == null)
            {
                user.Attendances = new List<Attendance>();
            }

           if(user.Attendances.Count > 0)
            {
                 var attDay = user.Attendances.SingleOrDefault(a => a.Day == todat.Day && a.Month == todat.Month && a.Year == todat.Year);
                if(attDay != null)
                {
                    if (status == "present")
                    {
                        attDay.Status = AttendanceStatus.Present;
                    }
                    else if (status == "absent")
                    {
                        attDay.Status = AttendanceStatus.Absent;
                    }
                    else
                    {
                        attDay.Status = AttendanceStatus.Holiday;
                    }
                    await _db.SaveChangesAsync();
                    return status;
                }
            }


           if(status == "present")
            {
                user.Attendances.Add(new Attendance
                {
                    Date = todat,
                    Day = todat.Day,
                    Month = todat.Month,
                    Year = todat.Year,
                    Status = AttendanceStatus.Present
                });
            }
            else if(status == "absent")
            {
                user.Attendances.Add(new Attendance
                {
                    Date = todat,
                    Day = todat.Day,
                    Month = todat.Month,
                    Year = todat.Year,
                    Status = AttendanceStatus.Absent
                });
            }
           else
            {
                user.Attendances.Add(new Attendance
                {
                    Date = todat,
                    Day = todat.Day,
                    Month = todat.Month,
                    Year = todat.Year,
                    Status = AttendanceStatus.Holiday
                });
            }

            await _db.SaveChangesAsync();
            return status;
         
        }

    }
}