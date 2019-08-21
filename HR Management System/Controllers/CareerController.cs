using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

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
            _accountManage.IsLoggedIn = false;
            //_accountManage.User = null;
            return RedirectToPage("/CareerPages/Career_Login");
        }


        public IActionResult Profile()
        {
            return RedirectToPage("/CareerPages/Profile");
        }


        public IActionResult ChangePassword()
        {
            
            return RedirectToPage("/CareerPages/ChangePassword");
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



        public async Task<string> ApplyForPost(long post_id, long applicant_id)
        {

            try
            {
                var notice = _db.RecruitementNotices.Include(o => o.Applicants).Single(i => i.Id == post_id);
                var CareerUser = await _db.Users.FindAsync(applicant_id);
                CareerUser.DateOfApplication = DateTime.Now;
                CareerUser.Department = notice.Department;
                CareerUser.Designation = notice.Designation;
                notice.Applicants.Add(CareerUser);
                await _db.SaveChangesAsync();
                Thread.Sleep(2000);
                return "success";
            }
            catch
            {
                return "failed";
            }

        }
    }
}