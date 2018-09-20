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
        public async void TestAdminLoginValidStateAndAdminRole()
        {
            var mockStore = new Mock<IUserStore<ApplicationUser>>();
            var mockUserManager = new Mock<UserManager<ApplicationUser>>(mockStore.Object, null, null, null, null, null, null, null, null);
            var mockHttpContext = new Mock<HttpContext>();
            var contextAccessor = new Mock<IHttpContextAccessor>();
            contextAccessor.Setup(mock => mock.HttpContext).Returns(() => mockHttpContext.Object);
            var mockSignInManager = new Mock<SignInManager<ApplicationUser>>(
                                    mockUserManager.Object,
                                    contextAccessor.Object,
                                    new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>().Object,
                                    new Mock<IOptions<IdentityOptions>>().Object,
                                    new Mock<ILogger<SignInManager<ApplicationUser>>>().Object,
                                    new Mock<IAuthenticationSchemeProvider>().Object);

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            ApplicationUser user = new ApplicationUser()
            {
                UserName = "test@email.com",
                Email = "test@email.com",
            };
            user.PasswordHash = passwordHasher.HashPassword(user, "Abcdefg1!");

            mockUserManager.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);
            mockUserManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(user);
            mockUserManager.Setup(x => x.IsInRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(true);
            mockUserManager.Setup(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            mockSignInManager.Setup(x => x.PasswordSignInAsync(
                                   It.IsAny<string>(), It.IsAny<string>(),
                                   It.IsAny<bool>(), It.IsAny<bool>()))
                                   .ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Success);

            await mockUserManager.Object.CreateAsync(user, "Abcdefg1!");
            await mockUserManager.Object.AddToRoleAsync(user, ApplicationRoles.Admin);

            AdminLoginModel alm = new AdminLoginModel(mockUserManager.Object, mockSignInManager.Object)
            {
                Email = "test@email.com",
                Password = "Abcdefg1!"
            };

            MockValidation.CheckValidation(alm);
            var result = alm.OnPost().Result;
            RedirectToPageResult check = (RedirectToPageResult)result;
            Assert.Equal("/Dashboard", check.PageName);
        }
    }
}
