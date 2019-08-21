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
    public class ManageNoticeModel : PageModel
    {
        public ManageNoticeModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }

        readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;


        [BindProperty]
        public List<Notice> Notices { get; set; }




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
               Notices = _db.Notices.Where(a => a.Title.IndexOf(src_string, StringComparison.CurrentCultureIgnoreCase) > -1).AsNoTracking().ToList();
            }
            else
            {
                Notices = _db.Notices.AsNoTracking().ToList();
            }

            return Page();
        }




        public async Task<IActionResult> OnGetViewNoticeAsync(long id)
        {
            var notice = await _db.Notices.FindAsync(id);
            if (notice != null)
                return RedirectToPage("/AdminPages/Notice/ViewNoticeDetails", notice);
            return Page();

        }



        public IActionResult OnGetEditNoticeAsync(long id)
        {
            return RedirectToPage("/AdminPages/Notice/EditNotice", new { id =id });
        }



        public async Task<IActionResult> OnGetDeleteAsync(long id)
        {
            var notice = await _db.Notices.FindAsync(id);
            _db.Notices.Remove(notice);
            await _db.SaveChangesAsync();
            return RedirectToPage();
        }



        public string IsPublished(bool val)
        {
            if(val == true)
            {
                return "Published";

            }

            return "Unpublished";
        }
    }
}