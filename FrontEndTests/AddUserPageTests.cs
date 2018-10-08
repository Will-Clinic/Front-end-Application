using System;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Pages;
using FrontEndTests.Utilities;
using Xunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using WAWillClinicFrontEnd.Data;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FrontEndTests
{
    public class AddUserPageTests
    {
        [Fact]
        public void TestAddUserPageGetterAndSetterName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                Add_UserModel aum = new Add_UserModel(context);
                Assert.Null(aum.Name);

                aum.Name = "Test Name";
                Assert.Equal("Test Name", aum.Name);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterEmail()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                Add_UserModel aum = new Add_UserModel(context);
                Assert.Null(aum.Email);

                aum.Email = "abc@123.com";
                Assert.Equal("abc@123.com", aum.Email);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterPhone()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                Add_UserModel aum = new Add_UserModel(context);
                Assert.Null(aum.PhoneNumber);

                aum.PhoneNumber = "0123456789";
                Assert.Equal("0123456789", aum.PhoneNumber);
            }
        }
        [Fact]
        public async void TestAddUserPageAddingAUserWithValidModelState()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                Add_UserModel aum = new Add_UserModel(context)
                {                     
                    Agree = true,
                    Name = "Test User",
                    Email = "abc@123.com",
                    PhoneNumber = "0123456789",
                    IsVeteran = true,
                    PreferredTime = false,
                    IsWashingtonResident = true,
                    ChooseMaritalStatus = MaritalStatus.SingleAndNeverDivorced,
                    SpouseName = "N/A",
                    HasChildren = false,
                    IsCurrentlyPregnant = false,
                    MinorChildName = "N/A",
                    ContRemBeneficiary = WhoToInheritEstate.OtherPerson,
                    PersonToInherit = WhoToInheritEstate.OtherPerson,
                    PersonalRep = WhoToInheritEstate.OtherPerson,
                };

                //Checking DB is actually empty
                var result = await context.Users.ToListAsync();
                Assert.Empty(result);

                MockValidation.CheckValidation(aum);
                await aum.OnPost();
                result = await context.Users.ToListAsync();
                Assert.Single(result);
            }
        }
        [Fact]
        public async void TestAddUserPageTryingToAddUserWithInvalidModelState()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                Add_UserModel aum = new Add_UserModel(context)
                {
                    Name = "Test User",
                    PhoneNumber = "0123456789"
                };

                //Checking DB is actually empty
                var result = await context.Users.ToListAsync();
                Assert.Empty(result);

                //Checking Validation of the Model
                MockValidation.CheckValidation(aum);
                var page = aum.OnPost().Result;
                Assert.IsType<PageResult>(page);
            }
        }
    }
}
