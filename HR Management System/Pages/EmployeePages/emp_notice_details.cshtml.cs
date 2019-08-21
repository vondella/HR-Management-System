using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using HR_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Models;

namespace HR_Management_System.Pages.EmployeePages
{
    public class emp_notice_detailsModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;

        [BindProperty]
        public HR_Management_System.Models.Notice Notice { get; set; }

        public emp_notice_detailsModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }


        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Employee || _accountManage.User.Status != true)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);


            if (id == null)
            {
                return NotFound();
            }

            Notice = await _db.Notices.FindAsync(id);

            if (Notice == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}