using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.AdminPages.Recruitment
{
    public class EditRecruitmentNoticeModel : PageModel
    {
        private readonly HRMS_DB_Context _db;


        [BindProperty]
        public bool Published { get; set; }

        [BindProperty]
        [Required]
        public string Title { get; set; }

        [BindProperty]
        [Required]
        public string Description { get; set; }

        [BindProperty]
        [Required]
        public DateTime EndDate { get; set; }

        [BindProperty]
        [Required]
        public int NumberOfVacancy { get; set; }

        [BindProperty]
        [Required]
        public long? Department { get; set; }

        [BindProperty]
        [Required]
        public long? Designation { get; set; }

        [BindProperty]
        public List<SelectListItem> DepartmentList { get; set; }

        [BindProperty]
        public List<SelectListItem> DesignationList { get; set; }





        public EditRecruitmentNoticeModel(HRMS_DB_Context db)
        {
            _db = db;
        }




        public void OnGet()
        {

        }

        //public async Task<IActionResult> OnGetAsync(long id)
        //{
        //    var departments = await _db.Departments.AsNoTracking().ToListAsync();
        //    DepartmentList = new List<SelectListItem>();
        //    if (departments != null)
        //    {
        //        if (departments.Count > 0)
        //        {
        //            foreach (var item in departments)
        //            {
        //                DepartmentList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Name });
        //            }
        //        }
        //    }


        //    var notice = _db.RecruitementNotices.Include(a => a.Department).Include(a => a.Designation).SingleOrDefault(a => a.Id == id);
        //    if (notice == null)
        //    {
        //        return NotFound();
        //    }

        //    Title = notice.Title;
        //    Description = notice.Description;
        //    Published = notice.IsPublished;
        //    Department = notice.Department.Id;

        //    var department = _db.Departments.Include(d => d.Designation).SingleOrDefault(a => a.Id == notice.Department.Id);

        //    DesignationList = new List<SelectListItem>();

        //    foreach (var designation_item in department.Designation)
        //    {
        //        DesignationList.Add(new SelectListItem { Value = designation_item.Id.ToString(), Text = designation_item.Name });
        //    }

        //    Designation = notice.Designation.Id;

        //    NumberOfVacancy = notice.NumberOfVacancy;
        //    EndDate = notice.LastDate;

        //    return Page();
        //}
    }
}