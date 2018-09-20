using System;
using System.Collections.Generic;
using System.Text;
using WAWillClinicFrontEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FrontEndTests.Utilities
{
    public class MockRSVPUserDb
    {
        /// <summary>
        /// Method that allows us to create a mock DB for testing 
        /// RSVPUser related methods and actions
        /// </summary>
        /// <returns>Context options to use in build test</returns>
        public static DbContextOptions<UserDbContext> TestRSVPDbContextOptions()
        {
            //Creating a new service provider for the in-memory db
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<UserDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }
    }
}
