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
    public class EmployeeSalaryListModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public EmployeeSalaryListModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public List<UserModel> Employees { get; set; }

        public IActionResult OnGet(string src_string)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            Employees = _db.Users.Include(a=>a.Salary).Where(a => a.UserType == UserType.Employee && a.Status == true).ToList();

            if (Employees != null)
            {
                if (src_string != null && src_string != "")
                {
                    if (Employees.Count > 0)
                    {
                        Employees = Employees.Where(a => a.Name.IndexOf(src_string, StringComparison.CurrentCultureIgnoreCase) > -1).ToList();
                    }
                }
            }


            return Page();
        }
    }
}