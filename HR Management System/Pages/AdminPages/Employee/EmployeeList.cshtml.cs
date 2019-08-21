using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages
{
    public class EmployeeListModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public EmployeeListModel(HRMS_DB_Context db, AccountManageModel accountManage)
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

           

            Employees = _db.Users.Where(a => a.UserType == UserType.Employee).ToList();



            if (src_string != null && src_string != "")
            {
                if (Employees.Count > 0)
                {
                    Employees = Employees.Where(a => a.Name.IndexOf(src_string, StringComparison.CurrentCultureIgnoreCase) > -1).ToList();
                }
            }


            return Page();
        }


        public string IsActive(bool a)
        {
            if (a == true)
            {
                return "Active";
            }
            else return "Inactive";
        }
    }
}