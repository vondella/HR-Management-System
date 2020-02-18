using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly HRMS_DB_Context _db;


        public DepartmentController(HRMS_DB_Context db)
        {
            _db = db;

        }






        //[HttpGet("{id}")]
        //public async Task<ActionResult<List<DesignationModel>>> Designations(long id)
        //{
        //    var department = await _db.Departments.Include(a => a.Designation).AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);

        //    var Designations = new List<DesignationModel>();

        //    if (department != null)
        //    {
        //        foreach (var designation_item in department.Designation)
        //        {
        //            var desig = new DesignationModel
        //            {
        //                Id = designation_item.Id,
        //                Name = designation_item.Name
        //            };
        //            Designations.Add(desig);
        //        }
        //    }

        //    return Designations;
        //}
    }
}