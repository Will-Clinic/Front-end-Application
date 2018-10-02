using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using WAWillClinicFrontEnd.Models;

namespace FrontEndTests.Utilities
{
    public class MockStoreContexts
    {
        //Creating a helper class to hold our contexts that will be defined
        public Mock<IUserStore<ApplicationUser>> Store { get; set; } = new Mock<IUserStore<ApplicationUser>>();
        public Mock<UserManager<ApplicationUser>> UserManager { get; set; }
        public Mock<HttpContext> HttpContext { get; set; } = new Mock<HttpContext>();
        public Mock<IHttpContextAccessor> ContextAccessor { get; set; } = new Mock<IHttpContextAccessor>();
        public Mock<SignInManager<ApplicationUser>> SignInManager { get; set; }
        public ApplicationUser User { get; set; } = new ApplicationUser
        {
            UserName = "test@email.com",
            Email = "test@email.com",
        };

        public MockStoreContexts()
        {
            UserManager = new Mock<UserManager<ApplicationUser>>(Store.Object, null, null, null, null, null, null, null, null);
            ContextAccessor.Setup(mock => mock.HttpContext).Returns(() => HttpContext.Object);
            SignInManager = new Mock<SignInManager<ApplicationUser>>(
                                    UserManager.Object,
                                    ContextAccessor.Object,
                                    new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>().Object,
                                    new Mock<IOptions<IdentityOptions>>().Object,
                                    new Mock<ILogger<SignInManager<ApplicationUser>>>().Object,
                                    new Mock<IAuthenticationSchemeProvider>().Object);

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            User.PasswordHash = passwordHasher.HashPassword(User, "Abcdefg1!");
        }

    }
}
