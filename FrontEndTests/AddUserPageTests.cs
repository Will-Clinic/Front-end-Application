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
using Microsoft.AspNetCore.Identity.UI.Services;

namespace FrontEndTests
{
    public class AddUserPageTests
    {
        [Fact]
        public void TestAddUserPageGetterAndSetterAgree()
        {
            using (var context = new UserDbContext
                (MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
                Assert.False(aum.Agree);

                aum.Agree = true;
                Assert.True(aum.Agree);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
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
                SignupModel aum = new SignupModel(context);
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
                SignupModel aum = new SignupModel(context);
                Assert.Null(aum.PhoneNumber);

                aum.PhoneNumber = "0123456789";
                Assert.Equal("0123456789", aum.PhoneNumber);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterIsVeteran()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
                Assert.False(aum.IsVeteran);

                aum.IsVeteran = true;
                Assert.True(aum.IsVeteran);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterIsWashingtonResident()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
                Assert.False(aum.IsWashingtonResident);

                aum.IsWashingtonResident = true;
                Assert.True(aum.IsWashingtonResident);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterPreferredTime()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
                Assert.False(aum.PreferredTime);

                aum.PreferredTime = true;
                Assert.True(aum.PreferredTime);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterMaritalStatus()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context)
                {
                    ChooseMaritalStatus = MaritalStatus.FirstMarriage
                };

                Assert.Equal(MaritalStatus.FirstMarriage, aum.ChooseMaritalStatus);
                aum.ChooseMaritalStatus = MaritalStatus.SecondMarriage;
                Assert.Equal(MaritalStatus.SecondMarriage, aum.ChooseMaritalStatus);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterSpouseName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
                Assert.Null(aum.SpouseName);

                aum.SpouseName = "Test Name";
                Assert.Equal("Test Name", aum.SpouseName);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterHasChildren()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
                Assert.False(aum.HasChildren);

                aum.HasChildren = true;
                Assert.True(aum.HasChildren);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterCurrentlyPregnant()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
                Assert.False(aum.IsCurrentlyPregnant);

                aum.IsCurrentlyPregnant = true;
                Assert.True(aum.IsCurrentlyPregnant);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterMinorChildName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context);
                Assert.Null(aum.MinorChildName);

                aum.MinorChildName = "Test Name";
                Assert.Equal("Test Name", aum.MinorChildName);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterContRemBeneficiary()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context)
                {
                    ContRemBeneficiary = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, aum.ContRemBeneficiary);

                aum.ContRemBeneficiary = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, aum.ContRemBeneficiary);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterPersonToInherit()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context)
                {
                    PersonToInherit = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, aum.PersonToInherit);

                aum.PersonToInherit = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, aum.PersonToInherit);
            }
        }
        [Fact]
        public void TestAddUserPageGetterAndSetterPersonalRep()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context)
                {
                    PersonalRep = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, aum.PersonalRep);

                aum.PersonalRep = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, aum.PersonalRep);
            }
        }

        [Fact]
        public async void TestAddUserPageAddingAUserWithValidModelState()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context)
                {    
                    Location = "Seattle",
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
                var page = await aum.OnPost();
                RedirectToPageResult check = (RedirectToPageResult)page;
                result = await context.Users.ToListAsync();

                Assert.Single(result);
                Assert.Equal("/Admin/Dashboard", check.PageName);
            }
        }
        [Fact]
        public async void TestAddUserPageTryingToAddUserWithInvalidModelState()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                SignupModel aum = new SignupModel(context)
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
