using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.EmployeePages
{
    public class Leave_ApplicationModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public Leave_ApplicationModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }




        public List<LeaveApplication> LeaveApplications { get; set; }




        public async Task<IActionResult> OnGetAsync()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Employee)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            if (_db.LeaveApplications.Any())
            {
                LeaveApplications =  await _db.LeaveApplications.Include(a=>a.LeaveCategory).Include(a => a.User).Where(a => a.User.Id == _accountManage.User.Id).ToListAsync();
            }

            return Page();
        }
    }
}