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

namespace HR_Management_System.Pages.AdminPages.Payroll
{
    public class DefineEmployeeSalaryModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public DefineEmployeeSalaryModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

        public UserModel Employee { get; set; }

     


        //Addition
        [BindProperty]
        [Required]
        public double BasicSalary { get; set; }

        [BindProperty]
        [Required]
        public double HouseRent { get; set; }

        [BindProperty]
        [Required]
        public double MobileBill { get; set; }

        [BindProperty]
        [Required]
        public double MedicalBill { get; set; }

        [BindProperty]
        [Required]
        public double Other { get; set; }



        //deduction
        [BindProperty]
        [Required]
        public double ProvidentFundDeduction { get; set; }

        [BindProperty]
        [Required]
        public double TaxDeduction { get; set; }

        [BindProperty]
        [Required]
        public double OtherDeduction { get; set; }





        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            Employee = await _db.Users.FindAsync(id);

            if(Employee == null)
            {
                return NotFound();
            }

            return Page();
        }



        public async Task<IActionResult> OnPostAsync(long id)
        {
            var employee = await _db.Users.Include(a => a.Salary).SingleAsync(a => a.Id == id);

            if(employee == null)
            {
                return NotFound();
            }

            //double gs;
            //double.TryParse(gross_salary, out gs);
            //double ns;
            //double.TryParse(net_salary, out ns);
            var gross_salary = BasicSalary + HouseRent + MedicalBill + MedicalBill + Other;
            var net_salary = gross_salary - (TaxDeduction + OtherDeduction + ProvidentFundDeduction);

            employee.Salary = new Salary
            {
                BasicSalary = BasicSalary,
                GrossSalary = gross_salary,
                HouseRent = HouseRent,
                MedicalBill = MedicalBill,
                MobileBill = MobileBill,
                NetSalary = net_salary,
                Other = Other,
                OtherDeduction = OtherDeduction,
                ProvidentFundDeduction = ProvidentFundDeduction,
                TaxDeduction = TaxDeduction,
                TotalDeduction = gross_salary - net_salary
            };

            await _db.SaveChangesAsync();

            return RedirectToPage("./ManageSalaryDetails");
        }
    }
}