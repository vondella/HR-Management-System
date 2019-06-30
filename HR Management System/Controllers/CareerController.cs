using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_System.Controllers
{
    public class CareerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Make_a_cv()
        {
            return RedirectToPage("/Make_a_cv");
        }
        public IActionResult Update_cv()
        {
            return RedirectToPage("/Update_cv");
        }
        public IActionResult Apply()
        {
            return RedirectToPage("/Apply");
        }
        public IActionResult CareerDashboard()
        {
            return RedirectToPage("/Career_Dashboard");
        }
        public IActionResult logout()
        {
            return RedirectToPage("/Career_Login");
        }
    }
}