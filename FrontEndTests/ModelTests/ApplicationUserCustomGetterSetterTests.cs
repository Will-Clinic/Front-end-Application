using System;
using Xunit;
using WAWillClinicFrontEnd.Models;
using System.Collections.Generic;
using System.Text;

namespace FrontEndTests.ModelTests
{
    public class ApplicationUserCustomGetterSetterTests
    {
        [Fact]
        public void FirstNameGetterAndSetter()
        {
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Bob"
            };
            Assert.Equal("Bob", user.FirstName);
            user.FirstName = "Steve";
            Assert.Equal("Steve", user.FirstName);
        }
        [Fact]
        public void LastNameGetterAndSetter()
        {
            ApplicationUser user = new ApplicationUser
            {
                LastName = "Doe"
            };
            Assert.Equal("Doe", user.LastName);
            user.LastName = "Smith";
            Assert.Equal("Smith", user.LastName);
        }
    }
}
