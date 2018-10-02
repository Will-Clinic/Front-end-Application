using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WAWillClinicFrontEnd.Models;
using FrontEndTests.Utilities;
using WAWillClinicFrontEnd.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Moq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace FrontEndTests
{
    public class ChangePasswordTests
    {
        [Fact]
        public void ChangePasswordNameGetterAndSetter()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            Change_PasswordModel cpm = new Change_PasswordModel(mocks.UserManager.Object, mocks.SignInManager.Object);

            Assert.Null(cpm.Name);
            cpm.Name = "some.email@place.com";
            Assert.Equal("some.email@place.com", cpm.Name);
        }
        [Fact]
        public void ChangePasswordPasswordGetterAndSetter()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            Change_PasswordModel cpm = new Change_PasswordModel(mocks.UserManager.Object, mocks.SignInManager.Object);

            Assert.Null(cpm.Password);
            cpm.Password = "Abcdefg1!";
            Assert.Equal("Abcdefg1!", cpm.Password);
        }
        [Fact]
        public void ChangePasswordConfirmPasswordGetterAndSetter()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            Change_PasswordModel cpm = new Change_PasswordModel(mocks.UserManager.Object, mocks.SignInManager.Object);

            Assert.Null(cpm.ConfirmPassword);
            cpm.ConfirmPassword = "Abcdefg1!";
            Assert.Equal("Abcdefg1!", cpm.ConfirmPassword);
        }
        [Fact]
        public void TestPasswordAndConfirmPasswordDoNotMatch()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            Change_PasswordModel cpm = new Change_PasswordModel(mocks.UserManager.Object, mocks.SignInManager.Object)
            {
                Password = "abcdefg1",
                ConfirmPassword = "Abcdefg1!"
            };

            var result = cpm.OnPostAsync().Result;
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public void TestPasswordAndConfirmPasswordDoMatchButInvalidModel()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            Change_PasswordModel cpm = new Change_PasswordModel(mocks.UserManager.Object, mocks.SignInManager.Object)
            {
                Password = "Abcdefg1!",
                ConfirmPassword = "Abcdefg1!"
            };

            MockValidation.CheckValidation(cpm);
            var result = cpm.OnPostAsync().Result;
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public void TestPasswordMatchingAndValidModelStateButNoUserIsFound()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            Change_PasswordModel cpm = new Change_PasswordModel(mocks.UserManager.Object, mocks.SignInManager.Object)
            {
                Name = "some.email@test.com",
                Password = "Abcdefg1!",
                ConfirmPassword = "Abcdefg1!"
            };

            mocks.UserManager.Setup(x => x.FindByNameAsync(It.IsAny<string>()))
                .ReturnsAsync((ApplicationUser)null);

            MockValidation.CheckValidation(cpm);
            var result = cpm.OnPostAsync().Result;
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public void TestPasswordMatchingAndValidModelStateAndUserButFailedToUpdate()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            Change_PasswordModel cpm = new Change_PasswordModel(mocks.UserManager.Object, mocks.SignInManager.Object)
            {
                Name = "some.email@test.com",
                Password = "Abcdefg1!",
                ConfirmPassword = "Abcdefg1!"
            };

            mocks.UserManager.Setup(x => x.FindByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(new ApplicationUser());
            mocks.UserManager.Setup(x => x.UpdateAsync(It.IsAny<ApplicationUser>()))
                .ReturnsAsync(new IdentityResult());

            MockValidation.CheckValidation(cpm);
            var result = cpm.OnPostAsync().Result;
            Assert.IsType<PageResult>(result);
        }
    }
}
