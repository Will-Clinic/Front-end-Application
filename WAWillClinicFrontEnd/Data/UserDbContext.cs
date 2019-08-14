using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>().HasData(

                new Resource
                {
                    ID = 1,
                    Title = "VA HealthCare",
                    Link = "https://www.va.gov/health-care/",
                    ImageURL = "",
                    Description = "",
                    Type = ResourceType.HealthCare
                },

                new Resource
                {
                    ID = 2,
                    Title = "OneSource",
                    Link = "https://www.militaryonesource.mil/",
                    ImageURL = "",
                    Description = "",
                    Type = ResourceType.Family
                },

                new Resource
                {
                    ID = 3,
                    Title = "VA Services",
                    Link = "https://www.benefits.va.gov/benefits/services.asp",
                    ImageURL = "",
                    Description = "",
                    Type = ResourceType.Finance
                }

                );
        }

        public DbSet<RSVPUser> Users { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
    }
}
