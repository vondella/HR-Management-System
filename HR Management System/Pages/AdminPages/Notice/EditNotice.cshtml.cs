using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using HR_Management_System.Models;

namespace HR_Management_System.Pages.AdminPages.Notice
{
    public class EditNoticeModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;

        public EditNoticeModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }




        public async Task<IActionResult> OnGetAsync(long id)
        {
            var notice = await _db.Notices.FindAsync(id);
            if(notice == null)
            {
                return NotFound();
            }

            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);


            Notice = notice;
          

            return Page();
        }


        [BindProperty]
        public Models.Notice Notice { get; set; }

        public Models.Notice Notice2 { get; set; }




        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var notice = await _db.Notices.FindAsync(Notice.Id);
            if(notice == null)
            {
                return NotFound();
            }

            notice.Published = Notice.Published;
            notice.Title = Notice.Title;
            notice.Description = Notice.Description;

            await _db.SaveChangesAsync();
            return RedirectToPage("/AdminPages/Notice/ManageNotice");
        }
    }
}