using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Xunit;
using WAWillClinicFrontEnd.Pages;
using FrontEndTests.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models.Services;
using WAWillClinicFrontEnd.Models;

namespace FrontEndTests
{
    public class ResourceManagerTests
    {
        [Fact]
        public async Task CreateResourceTest()
        {
            DbContextOptions<UserDbContext> options = new DbContextOptionsBuilder<UserDbContext>().UseInMemoryDatabase("Tests").Options;
            using (var context = new UserDbContext(options))
            {
                var Rm = new ResourceManager(context);

                Resource test = new Resource
                {
                    ID = 1,
                    Title = "Test Resource",
                    Link = "https://TestResource.net",
                    ImageURL = "https://FakeImageUrl.net",
                    Description = "Iam a test resource"
                };

                await Rm.CreateResource(test);

                Assert.Equal(test, await Rm.GetResourceById(test.ID));

            }
        }


    }
}

