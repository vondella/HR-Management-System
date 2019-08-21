using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HR_Management_System.Pages
{
    public class AddRecruitementNoticeModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;


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
        public DateTime EndDate { get; set; } = DateTime.Now;

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

        



        public AddRecruitementNoticeModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            var departments = await _db.Departments.AsNoTracking().ToListAsync();
            DepartmentList = new List<SelectListItem>();
            if(departments != null)
            {
                if (departments.Count > 0)
                {
                    foreach (var item in departments)
                    {
                        DepartmentList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Name });
                    }
                }
            }
            return Page();
        }




        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                DepartmentModel department = null;
                DesignationModel designation = null;

                if (Department != null)
                {
                    department = await _db.Departments.FindAsync((long)Department);
                }
                if (Designation != null)
                {
                    designation = await _db.Designations.FindAsync((long)Designation);
                }

                if (department == null) return NotFound();
                if (designation == null) return NotFound();

                var notice = new RecruitementNoticeModel
                {
                    Title = Title,
                    Description = Description,
                    LastDate = EndDate,
                    Department = department.Name,
                    Designation = designation.Name,
                    NumberOfVacancy = NumberOfVacancy,
                    IsPublished = Published,
                    CreatedDate = DateTime.Now
                };

                await _db.RecruitementNotices.AddAsync(notice);
                await _db.SaveChangesAsync();

                return RedirectToPage("./ManageRecruitmentNotice");
            }

            var departments = await _db.Departments.AsNoTracking().ToListAsync();
            DepartmentList = new List<SelectListItem>();
            if (departments != null)
            {
                if (departments.Count > 0)
                {
                    foreach (var item in departments)
                    {
                        DepartmentList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Name });
                    }
                }
            }
            Department = null;
            return Page();
        }
    }
}