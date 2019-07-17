using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.AdminPages.Department
{
    public class EditDepartmentModel : PageModel
    {
        private readonly HRMS_DB_Context _db;



        public DepartmentModel Department { get; set; }

        [Display(Name = "Department Name")]
        [BindProperty]
        [Required]
        public string DepartmentName { get; set; }

        [BindProperty]
        public List<DesignationModel> Designations { get; set; }



        public EditDepartmentModel(HRMS_DB_Context db)
        {
            _db = db;
        }


        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Department = await _db.Departments.Include(d=> d.Designation).FirstOrDefaultAsync(d=>d.Id == id);

            if(Department == null)
            {
                return NotFound();
            }


            DepartmentName = Department.Name;


            return Page();
        }
    }
}