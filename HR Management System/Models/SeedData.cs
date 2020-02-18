using HR_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HRMS_DB_Context(
                serviceProvider.GetRequiredService<DbContextOptions<HRMS_DB_Context>>()))
            {
                //context.Users.Add(new UserModel
                //{
                //    Email = "career@gmail.com",
                //    Name = "Career",
                //    Password = "1234",
                //    UserName = "career123",
                //    UserType = UserType.Career
                //});
                //context.SaveChanges();

                if (context.Users.Any() && context.WeekDays.Any())
                {
                    return;
                }

               

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                   new UserModel
                   {
                       Email = "admin@gmail.com",
                       Name = "Admin",
                       Password = "admin",
                       RememberMe = true,
                       UserName = "admin",
                       UserType = UserType.Admin
                   },

                   new UserModel
                   {
                       Email = "employee@gmail.com",
                       Name = "Employee",
                       Password = "1234",
                       RememberMe = true,
                       UserName = "employee",
                       UserType = UserType.Employee
                   },


                   new UserModel
                   {
                       Email = "career@gmail.com",
                       Name= "Career",
                       Password = "1234",
                       UserName = "career123",
                       UserType = UserType.Career
                   }
                   );
                   
                    context.SaveChanges();
                }


                if (!context.WeekDays.Any())
                {
                    context.WeekDays.AddRange(
                        new WeekDayModel
                        {
                            Name = "Saturday",
                            IsHoliday = false
                        },
                        new WeekDayModel
                        {
                            Name = "Sunday",
                            IsHoliday = false
                        },
                        new WeekDayModel
                        {
                            Name = "Monday",
                            IsHoliday = false
                        },
                        new WeekDayModel
                        {
                            Name = "Tuesday",
                            IsHoliday = false
                        },
                        new WeekDayModel
                        {
                            Name = "Wednesday",
                            IsHoliday = false
                        },
                        new WeekDayModel
                        {
                            Name = "Thursday",
                            IsHoliday = false
                        },
                        new WeekDayModel
                        {
                            Name = "Friday",
                            IsHoliday = true
                        }
                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
