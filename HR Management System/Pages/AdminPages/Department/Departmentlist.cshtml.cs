using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages
{
    public class DepartmentlistModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;
        public List<DepartmentModel> Departments { get; set; }


        public DepartmentlistModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db; _accountManage = accountManage;
        }



        public async Task<IActionResult> OnGetDeleteDepartmentAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _db.Departments.Include(a=>a.Designation).AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
            if (department == null)
            {
                return NotFound();
            }

            _db.Departments.Remove(department);
            await _db.SaveChangesAsync();

            return RedirectToPage();

        }


        public IActionResult OnGetEditDepartment(long? id)
        {
            return RedirectToPage("/AdminPages/Department/EditDepartment", new { id = id });
        }


        public IActionResult OnGet()
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            if (_db.Departments.Any())
            {
                Departments = _db.Departments.Include(d => d.Designation).AsNoTracking().ToList();
            }
            return Page();

            //Departments = _db.Departments.Select(d => new DepartmentModel
            //{
            //    Id = d.Id,
            //    Name = d.Name,
            //    Designation = d.Designation
            //}).ToList() ;
        }
    }
}