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
    public class EditSalaryModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public EditSalaryModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }



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









        public Salary Salary { get; set; }


        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);

            Salary = await _db.Salaries.FindAsync(id);

            if(Salary == null)
            {
                return NotFound();
            }


            BasicSalary = Salary.BasicSalary;
            HouseRent = Salary.HouseRent;
            MedicalBill = Salary.MedicalBill;
            MobileBill = Salary.MobileBill;
            Other = Salary.Other;
            OtherDeduction = Salary.OtherDeduction;
            ProvidentFundDeduction = Salary.ProvidentFundDeduction;
            TaxDeduction = Salary.TaxDeduction;
            

            return Page();
        }





        public async Task<IActionResult> OnPostAsync(long id)
        {
            Salary = await _db.Salaries.FindAsync(id);

            if (Salary == null)
            {
                return NotFound();
            }

          
            var gross_salary = BasicSalary + HouseRent + MedicalBill + MedicalBill + Other;
            var net_salary = gross_salary - (TaxDeduction + OtherDeduction + ProvidentFundDeduction);


            Salary.BasicSalary = BasicSalary;
            Salary.GrossSalary = gross_salary;
            Salary.HouseRent = HouseRent;
            Salary.MedicalBill = MedicalBill;
            Salary.MobileBill = MobileBill;
            Salary.NetSalary = net_salary;
            Salary.Other = Other;
            Salary.OtherDeduction = OtherDeduction;
            Salary.ProvidentFundDeduction = ProvidentFundDeduction;
            Salary.TaxDeduction = TaxDeduction;
            Salary.TotalDeduction = gross_salary - net_salary;
   
            await _db.SaveChangesAsync();

            return RedirectToPage("./EmployeeSalaryList");
        }
    }
}