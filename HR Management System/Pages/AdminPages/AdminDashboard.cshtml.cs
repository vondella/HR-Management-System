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
    public class DashboardModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public DashboardModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public int TotalEmployee { get; set; }
        public int TotalRecruitementNotices { get; set; }
        public int TotalDepartments { get; set; }
        public int TotalNotices { get; set; }


        public IActionResult OnGetAsync()
        {

            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            TotalEmployee = _db.Users.Where(a => a.UserType == UserType.Employee && a.Status == true).Count();
            TotalRecruitementNotices = _db.RecruitementNotices.Count();
            TotalDepartments = _db.Departments.Count();
            TotalNotices = _db.Notices.Count();

            return Page();
        }
    }
}