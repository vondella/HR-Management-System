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

        [BindProperty]
        public List<RecruitementNoticeModel> RecruitementNotices { get; set; }



        public ManageRecruitmentNoticeModel(HRMS_DB_Context db)
        {
            _db = db;
        }




        public void OnGet()
        {
            RecruitementNotices = _db.RecruitementNotices.AsNoTracking().ToList();
        }
    }
}