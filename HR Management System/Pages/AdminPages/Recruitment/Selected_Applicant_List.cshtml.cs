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

namespace HR_Management_System.Pages
{
    public class Selected_Applicant_ListModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public Selected_Applicant_ListModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        [BindProperty]
        public List<Applicant> SelectedApplicants { get; set; }

        public IActionResult OnGet(string src_string)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;

            SelectedApplicants = new List<Applicant>();

            if (_db.RecruitementNotices.Any())
            {
                var allnotices = _db.RecruitementNotices.Include(a => a.Applicants).ToList();
                foreach (var item in allnotices)
                {
                    if (item.LastDate.CompareTo(DateTime.Now) > 0)
                    {
                        if (item.Applicants != null)
                        {
                            if (item.Applicants.Count > 0)
                            {


                                foreach (var applicant_item in item.Applicants)
                                {
                                    if(applicant_item.SelectedForInterview == true && applicant_item.JoiningDate != null)
                                    {
                                        var applicant = new Applicant
                                        {
                                            Id = applicant_item.Id,
                                            DateOfApplication = applicant_item.DateOfApplication,
                                            Department = item.Department,
                                            Designation = item.Designation,
                                            Name = applicant_item.Name,
                                            DateOfInterview = applicant_item.InterviewDate
                                        };
                                        SelectedApplicants.Add(applicant);
                                    }
                                   
                                }
                            }
                        }
                    }
                }
            }

            if (src_string != "" && src_string != null)
            {
                if(SelectedApplicants.Count > 0)
                {
                    SelectedApplicants = SelectedApplicants.Where(a => a.Name.IndexOf(src_string, StringComparison.CurrentCultureIgnoreCase) > -1).ToList();
                }
               
            }

            return Page();
        }





        public string DateOfApplcationShortForm(DateTime? datetime)
        {
            if (datetime != null)
            {
                var date = (DateTime)datetime;
                return date.ToString("MMMM dd, yyyy");
            }
            else
            {
                return "Not Defined";
            }
        }






        public async Task<IActionResult> OnGetDelete(long id)
        {
            UserModel career_user = null;
            career_user = await _db.Users.FindAsync(id);
            if (career_user == null)
            {
                return NotFound();
            }
            career_user.SelectedForInterview = false;
            career_user.InterviewDate = null;
            await _db.SaveChangesAsync();
            return RedirectToPage();
        }

    }
}