using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Data;

namespace WAWillClinicFrontEnd.Models
{
    public class StartupDbInitializer
    {

        private static readonly List<IdentityRole> UserRoles = new List<IdentityRole>()
        {
            new IdentityRole{Name = ApplicationRoles.Admin, NormalizedName = ApplicationRoles.Admin.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString()},
            new IdentityRole{Name = ApplicationRoles.Member, NormalizedName = ApplicationRoles.Member.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString()}
        };

        public static void SeedData(IServiceProvider service, UserManager<ApplicationUser> userManager)
        {
            using(var dbContext = new ApplicationDbContext(service.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                dbContext.Database.EnsureCreated();
                AddRoles(dbContext);
            }
        }

        private static void AddRoles(ApplicationDbContext dbContext)
        {
            if (!dbContext.Roles.Any())
            {
                foreach(var roles in UserRoles)
                {
                    dbContext.Roles.Add(roles);
                    dbContext.SaveChanges();
                }
            }
        }

        
    }
}
