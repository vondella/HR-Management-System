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
                if (context.Users.Any())
                {
                    return;
                }

                context.Users.AddRange(
                    new UserModel
                    {
                        Email = "admin@gmail.com",
                        Name = "Admin",
                        Password = "admin",
                        RememberMe = true,
                        UserName = "admin"
                    }
                    ) ;
                context.SaveChanges();
            }
        }
    }
}
