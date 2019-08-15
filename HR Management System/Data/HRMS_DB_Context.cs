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


        public DbSet<DepartmentModel> Departments { get; set; }

        public DbSet<DesignationModel> Designations { get; set; }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<WeekDayModel> WeekDays { get; set; }

        public DbSet<HolidayModel> Holidays { get; set; }

        public DbSet<RecruitementNoticeModel> RecruitementNotices { get; set; }

        public DbSet<LeaveCategory> LeaveCategories { get; set; }

        public DbSet<Resume> Resumes { get; set; }



    }
}
