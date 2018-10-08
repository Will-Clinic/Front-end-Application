using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WAWillClinicFrontEnd.Data;

namespace FrontEndTests.Utilities
{
    public class MockIdentityDb
    {
        /// <summary>
        /// Method that allows us to create a mock DB for testing 
        /// Identity related methods and actions
        /// </summary>
        /// <returns>Context options to use in build test</returns>
        public static DbContextOptions<ApplicationDbContext> TestIdentityDbContextOptions()
        {
            //Creating a new service provider for the in-memory db
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }
    }
}
