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

namespace HR_Management_System.Pages.AdminPages.Employee
{
    public class AddAsEmployeeModel : PageModel
    {

        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public AddAsEmployeeModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public UserModel Applicant { get; set; }


        public bool UsernameExisted { get; set; } = false;

        [Required]
        [BindProperty]
        public DateTime JoiningDate { get; set; } = DateTime.Now;

        [BindProperty]
        [Required]
        public string Username { get; set; }


        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;

            Applicant = await _db.Users.FindAsync(id);


            return Page();
        }




        public async Task<IActionResult> OnPostAsync(long id)
        {
            var users = _db.Users.Where(a => a.UserName == Username).ToList();
            if(users != null)
            {
                if(users.Count> 0)
                {
                    UsernameExisted = true;
                    return Page();
                }
            }

            var user = await _db.Users.FindAsync(id);
            var notices = await _db.RecruitementNotices.Include(a => a.Applicants).ToListAsync();
           
            if (notices != null)
            {
                if(notices.Count> 0)
                {
                    bool done = false;
                    foreach (var item in notices)
                    {
                        
                        foreach(var apl in item.Applicants)
                        {
                            if(apl.Id == id)
                            {
                                user.Department = item.Department;
                                user.Designation = item.Designation;
                                done = true;
                                break;
                            }
                        }
                        if (done == true)
                            break;
                    }
                }
            }

            user.UserType = UserType.Employee;
            user.UserName = Username;
            user.JoiningDate = JoiningDate;
            await _db.SaveChangesAsync();

            notices = await _db.RecruitementNotices.Include(a => a.Applicants).ToListAsync();

           
           
            if (notices != null)
            {
                if (notices.Count > 0)
                {
                    bool done = false;
                    foreach (var item in notices)
                    {
                        UserModel u = null; 
                        foreach (var apl in item.Applicants)
                        {
                            if (apl.Id == id)
                            {
                                u = apl;
                                done = true;
                                break;
                            }
                        }
                        if( u!= null)
                        {
                            item.Applicants.Remove(u);
                            if (done == true)
                                break;
                        }
                        
                    }
                }
            }
            await _db.SaveChangesAsync();
            
            return RedirectToPage("./EmployeeList");
        }
    }
}