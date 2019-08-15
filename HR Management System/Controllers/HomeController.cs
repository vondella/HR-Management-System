using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HR_Management_System.Models;
using HR_Management_System.Data;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly HRMS_DB_Context _db;
        public HomeController(HRMS_DB_Context db)
        {
            _db = db;
        }


        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Login()
        {
            return RedirectToPage("/LoginPage");
        }

        public IActionResult CareerLogin()
        {
            return RedirectToPage("/CareerPages/Career_Login");
        }




        //[HttpGet("{id}")]
        public async Task<ActionResult<List<DesignationModel>>> Designations(long id)
        {
            var department = await _db.Departments.Include(a => a.Designation).AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);

            var Designations = new List<DesignationModel>();

            if (department != null)
            {
                foreach (var designation_item in department.Designation)
                {
                    var desig = new DesignationModel
                    {
                        Id = designation_item.Id,
                        Name = designation_item.Name
                    };
                    Designations.Add(desig);
                }
            }

            return Designations;
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
