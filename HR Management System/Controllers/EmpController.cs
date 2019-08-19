using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HR_Management_System.Data;
using HR_Management_System.Models;




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



    }
}