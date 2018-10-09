using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Xunit;
using WAWillClinicFrontEnd.Pages;
using FrontEndTests.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndTests
{
    public class LogOutPageTests
    {
        [Fact]
        public void LogOutFunctionsProperly()
        {
            MockStoreContexts mock = new MockStoreContexts();
            LogoutModel lm = new LogoutModel(mock.SignInManager.Object);

            mock.SignInManager.Setup(x => x.SignOutAsync())
                .Returns(Task.CompletedTask);

            var result = lm.OnGet().Result;
            RedirectToPageResult check = (RedirectToPageResult)result;
            Assert.Equal("/", check.PageName);
        }
    }
}
