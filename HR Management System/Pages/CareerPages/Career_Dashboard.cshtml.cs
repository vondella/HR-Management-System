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
    public class Career_DashboardModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;

        public List<RecruitementNoticeModel> RecruitementNotices { get; set; }

        public Career_DashboardModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            if(_accountManage.IsLoggedIn == true)
            {
                if(_accountManage.User != null)
                {
                    if(_accountManage.User.UserType == UserType.Career)
                    {
                        ViewData.Add("User_Name", _accountManage.User.Name);
                        ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
                        RecruitementNotices = await _db.RecruitementNotices.Where(a => a.IsPublished == true).AsNoTracking().ToListAsync();
                        return Page();
                    }
                }
            }

            return RedirectToPage("./Career_Login");
        }




        public IActionResult OnGetView(long id)
        {
            return RedirectToPage("./ViewRecruitmentNotice", new { id = id});
        }
    }
}