using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class Salary
    {
        public long Id { get; set; }

        

        public double GrossSalary { get; set; }
        public double NetSalary { get; set; }
        public double TotalDeduction { get; set; }


        //Addition
        public double BasicSalary { get; set; }

        public double HouseRent { get; set; }

        public double MobileBill { get; set; }

        public double MedicalBill { get; set; }

        public double Other { get; set; }



        //deduction
        public double ProvidentFundDeduction { get; set; }

        public double TaxDeduction { get; set; }

        public double OtherDeduction { get; set; }

       
    }
}
