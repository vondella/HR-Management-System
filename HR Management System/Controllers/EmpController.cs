using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_System.Controllers
{
    public class EmpController : Controller
    {
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
        
    }
}