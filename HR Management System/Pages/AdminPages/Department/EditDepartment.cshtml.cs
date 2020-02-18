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
        private readonly AccountManageModel _accountManage;

        [BindProperty]
        public DepartmentModel Department { get; set; }

        [Display(Name = "Department Name")]
        [BindProperty]
        [Required]
        public string DepartmentName { get; set; }

        [BindProperty]
        public List<DesignationModel> Designations { get; set; }



        public EditDepartmentModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }




        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);


            Department = await _db.Departments.Include(d=> d.Designation).FirstOrDefaultAsync(d=>d.Id == id);

            if(Department == null)
            {
                return NotFound();
            }


            DepartmentName = Department.Name;
            Designations = new List<DesignationModel>();
            if(Department.Designation != null)
            {
                if(Department.Designation.Count > 0)
                {
                    foreach(var item in Department.Designation)
                    {
                        Designations.Add(new DesignationModel()
                        {
                            Id = item.Id,
                            Name = item.Name
                        });
                    }
                    
                }
            }
            
            return Page();
        }


        public async Task<IActionResult> OnPostAsync(List<string> designations, string department_name, long? id)
        {
            var _id = (long)id;
            if(designations.Count > 0 && department_name != "" && department_name != null)
            {
                var _department = await _db.Departments.FindAsync(_id);
                if(_department == null)
                {
                    return NotFound();
                }
                _db.Departments.Remove(_department);
                await _db.SaveChangesAsync();

                var d = new DepartmentModel();
                d.Name = department_name;

                d.Designation = new List<DesignationModel>();
                foreach(var desig_name in designations)
                {
                    if(desig_name != "" && desig_name != null)
                    {
                        var de = new DesignationModel();
                        de.Name = desig_name;
                        d.Designation.Add(de);
                    }
                }

                if(d.Designation.Count == 0)
                {
                    return Page();
                }

                _db.Departments.Add(d);
                await _db.SaveChangesAsync();
                return RedirectToPage("/AdminPages/Department/Departmentlist");
            }
            return Page();
        }
    }
}