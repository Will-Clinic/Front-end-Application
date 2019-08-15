using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Models.Interfaces;
using WAWillClinicFrontEnd.Models.Services;

namespace WAWillClinicFrontEnd
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            // For production.
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            string ConnectionString = Environment.IsDevelopment()
                ? Configuration.GetConnectionString("DefaultConnection")
                : Configuration.GetConnectionString("ProductionConnection");


            string UserConnectionString = Environment.IsDevelopment()
                ? Configuration.GetConnectionString("UserDefaultConnection")
                : Configuration.GetConnectionString("UserProductionConnection");

            string BlobConnection = Configuration.GetConnectionString("BlobConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(UserConnectionString));

            services.AddDbContext<UserDbContext>(options =>
                    options.UseSqlServer(ConnectionString));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole(ApplicationRoles.Admin));
                options.AddPolicy("Member", policy => policy.RequireRole(ApplicationRoles.Member));
            });

            services.ConfigureApplicationCookie(options => options.LoginPath = "/AdminLogin");

            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IResource, ResourceManager>();
            services.AddScoped<IBlob, BlobManager>();
            services.AddScoped<IVolunteer, VolunteerManager>();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Oops, something went wrong");
            });
        }
    }
}
