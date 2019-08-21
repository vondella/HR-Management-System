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
    public class ManageRecruitmentNoticeModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;

        [BindProperty]
        public List<RecruitementNoticeModel> RecruitementNotices { get; set; }



        public ManageRecruitmentNoticeModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }




        public IActionResult OnGet(string src_string)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);


            if (src_string != null && src_string != "")
            {
                RecruitementNotices = _db.RecruitementNotices.Where(a => a.Title.IndexOf(src_string, StringComparison.CurrentCultureIgnoreCase) > -1).AsNoTracking().ToList();
            }
            else
            {
                RecruitementNotices = _db.RecruitementNotices.AsNoTracking().ToList();
            }
            return Page();
        }


        public string IsPublished(bool published)
        {
            if (published == true)
            {
                return "Published";
            }
            else return "Unpublished";
        }






        public async Task<IActionResult> OnGetDeleteAsync(long id)
        {
            var notice = await _db.RecruitementNotices.Include(a=>a.Applicants).SingleAsync(o=>o.Id == id);
            if(notice == null)
            {
                return NotFound();
            }

            _db.RecruitementNotices.Remove(notice);
            await _db.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}