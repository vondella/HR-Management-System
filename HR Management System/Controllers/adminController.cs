using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_System.Controllers
{
    public class adminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult adminDashboard()
        {
            return RedirectToPage("/AdminDashboard");
        }

        public IActionResult SetWorkingDays()
        {
            return RedirectToPage("/Set_Working_Days");
        }
        public IActionResult Add_Employee()
        {
            return RedirectToPage("/Add_Employee");
        }

        public IActionResult logout()
        {
            return RedirectToPage("/LoginPage");
        }


        public IActionResult LeaveCategory()
        {
            return RedirectToPage("/LeaveCategory");
        }
        public IActionResult AddDepartment()
        {
            return RedirectToPage("/AddDepartment");
        }
        public IActionResult Departmentlist()
        {
            return RedirectToPage("/Departmentlist");
        }
        public IActionResult AddEmployee()
        {
            return RedirectToPage("/AddEmployee");
        }
    }
}