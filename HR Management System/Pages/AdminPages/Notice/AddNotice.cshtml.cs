using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Models;
using HR_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages
{
    public class AddNoticeModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        public AddNoticeModel(HRMS_DB_Context db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public bool Published { get; set; }


        public IActionResult OnPost( string title, string long_description, bool published)
        {
            if(title != "" && title != null && long_description != "" && long_description != null)
            {
                var new_notice = new Notice();
                new_notice.Published = published;
                new_notice.Title = title;
                new_notice.Description = long_description;

                _db.Notices.Add(new_notice);
                _db.SaveChanges();

                return RedirectToPage("/AdminPages/Notice/ManageNotice");
            }

            return Page();
        }
    }
}