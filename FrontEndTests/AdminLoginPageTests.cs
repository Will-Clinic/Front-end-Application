using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Identity;
using WAWillClinicFrontEnd.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using WAWillClinicFrontEnd.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;
using FrontEndTests.Utilities;

namespace FrontEndTests
{
    public class AdminLoginPageTests
    {
        [Fact]
        public void AdminLoginEmailGetterAndSetter()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            AdminLoginModel alm = new AdminLoginModel(mocks.UserManager.Object, mocks.SignInManager.Object);

            Assert.Null(alm.Email);
            alm.Email = "some.email@place.com";
            Assert.Equal("some.email@place.com", alm.Email);
        }
        [Fact]
        public void AdminLoginPasswordGetterAndSetter()
        {
            MockStoreContexts mocks = new MockStoreContexts();
            AdminLoginModel alm = new AdminLoginModel(mocks.UserManager.Object, mocks.SignInManager.Object);

            Assert.Null(alm.Password);
            alm.Password = "Abcdefg1!";
            Assert.Equal("Abcdefg1!", alm.Password);
        }
        [Fact]
        public async void TestAdminLoginValidStateAndAdminRole()
        {
            MockStoreContexts mocks = new MockStoreContexts();

            mocks.UserManager.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);
            mocks.UserManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(mocks.User);
            mocks.UserManager.Setup(x => x.IsInRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(true);
            mocks.UserManager.Setup(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            mocks.SignInManager.Setup(x => x.PasswordSignInAsync(
                                   It.IsAny<string>(), It.IsAny<string>(),
                                   It.IsAny<bool>(), It.IsAny<bool>()))
                                   .ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Success);

            await mocks.UserManager.Object.CreateAsync(mocks.User, "Abcdefg1!");
            await mocks.UserManager.Object.AddToRoleAsync(mocks.User, ApplicationRoles.Admin);

            AdminLoginModel alm = new AdminLoginModel(mocks.UserManager.Object, mocks.SignInManager.Object)
            {
                Email = "test@email.com",
                Password = "Abcdefg1!"
            };

            MockValidation.CheckValidation(alm);
            var result = alm.OnPost().Result;
            RedirectToPageResult check = (RedirectToPageResult)result;
            Assert.Equal("/Dashboard", check.PageName);
        }
        [Fact]
        public async void TestAdminLoginInvalidState()
        {
            MockStoreContexts mocks = new MockStoreContexts();

            mocks.UserManager.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);
            mocks.UserManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(mocks.User);
            mocks.UserManager.Setup(x => x.IsInRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(true);
            mocks.UserManager.Setup(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            mocks.SignInManager.Setup(x => x.PasswordSignInAsync(
                                   It.IsAny<string>(), It.IsAny<string>(),
                                   It.IsAny<bool>(), It.IsAny<bool>()))
                                   .ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Success);

            await mocks.UserManager.Object.CreateAsync(mocks.User, "Abcdefg1!");
            await mocks.UserManager.Object.AddToRoleAsync(mocks.User, ApplicationRoles.Admin);

            AdminLoginModel alm = new AdminLoginModel(mocks.UserManager.Object, mocks.SignInManager.Object)
            {
                Email = "test@email.com",
                Password = ""
            };

            MockValidation.CheckValidation(alm);
            var result = alm.OnPost().Result;
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async void TestAdminLoginValidModelStateButNotAnExistingUser()
        {
            MockStoreContexts mocks = new MockStoreContexts();

            mocks.UserManager.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);
            mocks.UserManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(mocks.User);
            mocks.UserManager.Setup(x => x.IsInRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(true);
            mocks.UserManager.Setup(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            mocks.SignInManager.Setup(x => x.PasswordSignInAsync(
                                   It.IsAny<string>(), It.IsAny<string>(),
                                   It.IsAny<bool>(), It.IsAny<bool>()))
                                   .ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Failed);

            await mocks.UserManager.Object.CreateAsync(mocks.User, "Abcdefg1!");
            await mocks.UserManager.Object.AddToRoleAsync(mocks.User, ApplicationRoles.Admin);

            AdminLoginModel alm = new AdminLoginModel(mocks.UserManager.Object, mocks.SignInManager.Object)
            {
                Email = "woo@email.com",
                Password = "AHWDUilf"
            };

            MockValidation.CheckValidation(alm);
            var result = alm.OnPost().Result;
            Assert.IsType<PageResult>(result);
        }
    }
}
