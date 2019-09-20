using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seeds an Admin into Db to allow login to Dashboard
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    FirstName = "Admin",
                    LastName = "Test",
                    Email = "admin@admin.com"

                });
        }
    }
}
