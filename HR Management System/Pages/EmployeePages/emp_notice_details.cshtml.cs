using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HR_Management_System.Models;
using HR_Management_System.Data;

namespace HR_Management_System.Pages.EmployeePages
{
    public class emp_notice_detailsModel : PageModel
    {
        private readonly HRMS_DB_Context _db;


        [BindProperty]
        public HR_Management_System.Models.Notice Notice { get; set; }

        public emp_notice_detailsModel(HRMS_DB_Context db)
        {
            _db = db;
        }


        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Notice = await _db.Notices.FindAsync(id);

            if (Notice == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}