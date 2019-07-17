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

        public List<DepartmentModel> Departments { get; set; }


        public DepartmentlistModel(HRMS_DB_Context db)
        {
            _db = db;
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



        public void OnGet()
        {
            if(_db.Departments.Any())
            {
                Departments = _db.Departments.Include(d => d.Designation).AsNoTracking().ToList();
            }


            //Departments = _db.Departments.Select(d => new DepartmentModel
            //{
            //    Id = d.Id,
            //    Name = d.Name,
            //    Designation = d.Designation
            //}).ToList() ;
        }
    }
}