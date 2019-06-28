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
                if(context.Users.Any() && context.CareerUsers.Any())
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
                       UserName = "admin"
                   }
                   );

                    context.SaveChanges();
                }


                if (!context.CareerUsers.Any())
                {
                    context.CareerUsers.AddRange(
                    new CareerUser
                    {
                        Email = "shakir@gmail.com",
                        FirstName = "Shakir",
                        LastName = "Ahmed",
                        Password = "12345",
                        Username = "shakir12345"
                    });
                    context.SaveChanges();
                }
                
            }
        }
    }
}
