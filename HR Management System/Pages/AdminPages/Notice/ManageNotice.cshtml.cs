﻿using System;
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
        public ManageNoticeModel(HRMS_DB_Context db)
        {
            _db = db;
        }

        readonly HRMS_DB_Context _db;


        [BindProperty]
        public List<Notice> Notices { get; set; }




        public void OnGet()
        {
            if (_db.Notices.Any())
            {
                Notices = _db.Notices.AsNoTracking().ToList();
            }
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