using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.AdminPages.Recruitment
{
    public class SelectApplicantModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public SelectApplicantModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public UserModel Career_user { get; set; }


        [Required]
        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime InterviewDate { get; set; } = DateTime.Now;

        [Required]
        [BindProperty]
        [DataType(DataType.Time)]
        public DateTime InterviewTime { get; set; } = DateTime.Now;


        public IActionResult OnGet(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;

          
            try
            {
                Career_user = _db.Users.Include(a => a.Resume).Single(a => a.Id == id);
                
            }
            catch
            {
                return NotFound();
            }

            return Page();
        }





        public async Task<IActionResult> OnPostAsync(long id)
        {
            if (ModelState.IsValid)
            {
                var u = await _db.Users.FindAsync(id);
               
                u.InterviewDate = new DateTime(InterviewDate.Year, InterviewDate.Month, InterviewDate.Day, InterviewTime.Hour, InterviewTime.Minute, InterviewTime.Second);
                u.SelectedForInterview = true;
                
                await _db.SaveChangesAsync();
                return RedirectToPage("./Recruitment_Applicant_List");
            }
            return Page();
        }
    }
}