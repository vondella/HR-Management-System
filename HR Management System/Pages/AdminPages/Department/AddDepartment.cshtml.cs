using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using System.ComponentModel.DataAnnotations;
using HR_Management_System.Models;
using System.Threading;
using HR_Management_System.Models;


namespace HR_Management_System.Pages
{
    public class AddDepartmentModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel  _accountManage;

        public AddDepartmentModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }


        [Display(Name = "Add Department Name")]
        [BindProperty]
        [Required]
        public string department_name { get; set; }
        
        [Required]
        [BindProperty]
        public List<string> Designations { get; set; }



        public IActionResult OnGet()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);
            return Page();
        }

        public IActionResult OnPost(string department_name, string[] designations)
        {
            if(department_name == "" || department_name == null || designations.Length == 0)
            {
                return Page();
            }

            var department = new DepartmentModel();
            department.Name = department_name;
            department.Designation = new List<DesignationModel>();
            foreach (var designationItem in designations)
            {
                if (designationItem != "" && designationItem != null)
                {
                    
                    department.Designation.Add(new DesignationModel { Name = designationItem });
                }
            }

            _db.Departments.Add(department);
            _db.SaveChanges();
            
            return RedirectToPage("/AdminPages/Department/Departmentlist");
        }





       
    }   
}