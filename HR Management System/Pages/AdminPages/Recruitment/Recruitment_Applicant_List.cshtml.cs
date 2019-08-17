using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages
{
    public class Recruitment_Applicant_ListModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;


        public Recruitment_Applicant_ListModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }




        public List<Applicant> Applicants { get; set; }




        public IActionResult OnGet(string src_string)
        {
 
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;

            Applicants = new List<Applicant>();

            if (_db.RecruitementNotices.Any())
            {
                var allnotices = _db.RecruitementNotices.Include(a=> a.Applicants).ToList();
                foreach (var item in allnotices)
                {
                    if(item.LastDate.CompareTo(DateTime.Now) > 0)
                    {
                        if(item.Applicants != null)
                        {
                            if (item.Applicants.Count > 0)
                            {
                                

                                foreach(var applicant_item in item.Applicants)
                                {
                                    var applicant = new Applicant
                                    {
                                        Id = applicant_item.Id,
                                        DateOfApplication = applicant_item.DateOfApplication,
                                        Department = item.Department,
                                        Designation = item.Designation,
                                        Name = applicant_item.Name
                                    };
                                    Applicants.Add(applicant);
                                }
                            }
                        }
                    } 
                }
            }

            if(src_string != "" && src_string != null)
            {
                long id;
                if(long.TryParse(src_string, out id))
                {
                    Applicants = Applicants.Where(a => a.Id == id).ToList();
                }
                
            }

            return Page();
        }





        public string DateOfApplcationShortForm(DateTime? datetime)
        {
            if(datetime != null)
            {
                var date = (DateTime)datetime;
                return date.ToString("MMMM dd, yyyy");
            }
            else
            {
                return "Not Defined";
            }
        }




        public IActionResult OnGetView(long id)
        {
            return RedirectToPage("./Applicant_details", new {id = id });
        }
    }
}