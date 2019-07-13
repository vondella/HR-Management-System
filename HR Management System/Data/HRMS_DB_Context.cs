using HR_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Data
{
    public class HRMS_DB_Context: DbContext
    {
        public HRMS_DB_Context(DbContextOptions<HRMS_DB_Context> options)
           : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<CareerUser> CareerUsers { get; set; }

        public DbSet<DepartmentModel> Departments { get; set; }


    }
}
