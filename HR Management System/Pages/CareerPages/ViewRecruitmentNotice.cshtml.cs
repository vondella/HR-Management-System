using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.CareerPages
{
    public class ViewRecruitmentNoticeModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        public readonly AccountManageModel _accountManage;


        [BindProperty]
        public RecruitementNoticeModel RecruitmentNotice { get; set; }

        public bool Applied { get; set; }


        public ViewRecruitmentNoticeModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public IActionResult OnGetAsync(long id)
        {
            if (_accountManage.IsLoggedIn == true)
            {
                if (_accountManage.User != null)
                {
                    if (_accountManage.User.UserType == UserType.Career)
                    {
                        ViewData.Add("User_Name", _accountManage.User.Name);
                        ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
                        RecruitmentNotice =  _db.RecruitementNotices.Include(a=>a.Applicants).Single(a=>a.Id == id);
                        var gg = RecruitmentNotice.Applicants.Where(p => p.Id == _accountManage.User.Id).FirstOrDefault();
                        if (gg != null)
                        {
                            Applied = true;
                        }
                        else Applied = false;

                        return Page();
                    }
                }
            }

           return RedirectToPage("./Career_Login");
        }
    }
}