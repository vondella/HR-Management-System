using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.EmployeePages
{
    public class New_leaveModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public New_leaveModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }



        [BindProperty]
        [Required]
        public long LeaveCategory { get; set; }


        [BindProperty]
        public List<SelectListItem> LeaveCategories { get; set; }


        [BindProperty]
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [BindProperty]
        [Required]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [BindProperty]
        public string Reason { get; set; }


        public bool InValidDateSelected { get; set; } = false;





        public async Task<IActionResult> OnGetAsync(string src_string)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Employee)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);


            var lc = await _db.LeaveCategories.AsNoTracking().ToListAsync();
            LeaveCategories = new List<SelectListItem>();
            if (lc != null)
            {
                if (lc.Count > 0)
                {
                    foreach (var item in lc)
                    {
                        LeaveCategories.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Title });
                    }
                }
            }
            return Page();
        }




        public async Task<IActionResult> OnPostAsync()
        {
            if (StartDate.CompareTo(EndDate) > 0)
            {
                InValidDateSelected = true;

                var lc = await _db.LeaveCategories.AsNoTracking().ToListAsync();
                LeaveCategories = new List<SelectListItem>();
                if (lc != null)
                {
                    if (lc.Count > 0)
                    {
                        foreach (var item in lc)
                        {
                            LeaveCategories.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Title });
                        }
                    }
                }

                ViewData["User_Name"] = _accountManage.User.Name;
                ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
                return Page();
            }

            var leavecategory = await _db.LeaveCategories.FindAsync(LeaveCategory);
            var user = await _db.Users.Include(a=>a.LeaveApplications).SingleAsync(a=>a.Id == _accountManage.User.Id);
            var totalDays = EndDate - StartDate;


            var leaveApplication = new LeaveApplication
            {
                EndDate = EndDate,
                StartDate = StartDate,
                LeaveCategory = leavecategory,
                Reason = Reason,
                Days = (int)(totalDays.TotalDays + 1),
                User = user,
                Status = LeaveApplicationStatus.Pending,
                AppliedDate = DateTime.Now
            };

            user.LeaveApplications.Add(leaveApplication);
            
            await _db.SaveChangesAsync();

            return RedirectToPage("./Leave_Application");
        }
    }
}