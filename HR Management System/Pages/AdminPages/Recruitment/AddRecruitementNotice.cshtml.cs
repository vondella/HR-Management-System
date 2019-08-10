using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HR_Management_System.Pages
{
    public class AddRecruitementNoticeModel : PageModel
    {
        private readonly HRMS_DB_Context _db;


        [BindProperty]
        public bool Published { get; set; }

        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }

        [BindProperty]
        public int NumberOfVacancy { get; set; }

        [BindProperty]
        public string Department { get; set; }


        public List<SelectListItem> DepartmentList { get; set; }

        



        public AddRecruitementNoticeModel(HRMS_DB_Context db)
        {
            _db = db;
        }


        public void OnGet()
        {

        }




    }
}