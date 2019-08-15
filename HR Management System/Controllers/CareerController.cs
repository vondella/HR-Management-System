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
    public class CareerController : Controller
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;
        
        public CareerController(HRMS_DB_Context DB, AccountManageModel accountManage)
        {
            _db = DB;
            _accountManage = accountManage;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Make_a_cv()
        {
            return RedirectToPage("/CareerPages/Make_a_cv");
        }
        public IActionResult Update_cv()
        {
            return RedirectToPage("/CareerPages/Update_cv");
        }
        public IActionResult Apply()
        {
            return RedirectToPage("/CareerPages/Apply");
        }
        public IActionResult CareerDashboard()
        {
            return RedirectToPage("/CareerPages/Career_Dashboard");
        }
        public IActionResult logout()
        {
            return RedirectToPage("/CareerPages/Career_Login");
        }
        public IActionResult Profile()
        {
            return RedirectToPage("/CareerPages/Profile");
        }
        public IActionResult view_cv()
        {
            UserModel user = null;
            user = _db.Users.Include(o => o.Resume).Single(a =>a.Id == _accountManage.User.Id);
            if(user == null)
            {
                return NotFound();
            }
            if(user.Resume != null)
            {
                return RedirectToPage("/CareerPages/ViewCV", new { id = user.Resume.Id });
            }
            else
            {
                return RedirectToPage("/CareerPages/ViewCV");
            }
           
        }

    }
}