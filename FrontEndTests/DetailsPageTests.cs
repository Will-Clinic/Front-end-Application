using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WAWillClinicFrontEnd.Pages;
using WAWillClinicFrontEnd.Data;
using FrontEndTests.Utilities;
using WAWillClinicFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FrontEndTests
{
    public class DetailsPageTests
    {
        [Fact]
        public void TestDetailsPageGetterAndSetterID()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context)
                {
                    ID = 1
                };
                Assert.Equal(1, dm.ID);

                dm.ID = 2;
                Assert.Equal(2, dm.ID);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.Null(dm.Name);

                dm.Name = "Test Name";
                Assert.Equal("Test Name", dm.Name);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterEmail()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.Null(dm.Email);

                dm.Email = "abc@123.com";
                Assert.Equal("abc@123.com", dm.Email);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterPhone()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.Null(dm.Phone);

                dm.Phone = "0123456789";
                Assert.Equal("0123456789", dm.Phone);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterIsVeteran()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.False(dm.IsVeteran);

                dm.IsVeteran = true;
                Assert.True(dm.IsVeteran);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterIsWashingtonResident()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.False(dm.IsWashingtonResident);

                dm.IsWashingtonResident = true;
                Assert.True(dm.IsWashingtonResident);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterPreferredTime()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.False(dm.PreferredTime);

                dm.PreferredTime = true;
                Assert.True(dm.PreferredTime);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterMaritalStatus()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context)
                {
                    ChooseMaritalStatus = MaritalStatus.FirstMarriage
                };

                Assert.Equal(MaritalStatus.FirstMarriage, dm.ChooseMaritalStatus);
                dm.ChooseMaritalStatus = MaritalStatus.SecondMarriage;
                Assert.Equal(MaritalStatus.SecondMarriage, dm.ChooseMaritalStatus);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterSpouseName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.Null(dm.SpouseName);

                dm.SpouseName = "Test Name";
                Assert.Equal("Test Name", dm.SpouseName);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterHasChildren()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.False(dm.HasChildren);

                dm.HasChildren = true;
                Assert.True(dm.HasChildren);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterCurrentlyPregnant()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.False(dm.IsCurrentlyPregnant);

                dm.IsCurrentlyPregnant = true;
                Assert.True(dm.IsCurrentlyPregnant);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterMinorChildName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.Null(dm.MinorChildName);

                dm.MinorChildName = "Test Name";
                Assert.Equal("Test Name", dm.MinorChildName);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterContRemBeneficiary()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context)
                {
                    ContRemBeneficiary = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, dm.ContRemBeneficiary);

                dm.ContRemBeneficiary = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, dm.ContRemBeneficiary);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterPersonToInherit()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context)
                {
                    PersonToInherit = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, dm.PersonToInherit);

                dm.PersonToInherit = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, dm.PersonToInherit);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterPersonalRep()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context)
                {
                    PersonalRep = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, dm.PersonalRep);

                dm.PersonalRep = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, dm.PersonalRep);
            }
        }
        [Fact]
        public void TestDetailsPageGetterAndSetterIsCheckedIn()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                Assert.False(dm.CheckedIn);

                dm.CheckedIn = true;
                Assert.True(dm.CheckedIn);
            }
        }

        [Fact]
        public void TestDetailsPageOnGetWithoutIDValue()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                var page = dm.OnGet(null);
                RedirectToPageResult check = (RedirectToPageResult)page;
                Assert.Equal("/Dashboard", check.PageName);
            }
        }
        [Fact]
        public void TestDetailsPageOnGetWithIDValueButUserIsNull()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                var page = dm.OnGet(1);

                RedirectToPageResult check = (RedirectToPageResult)page;
                Assert.Equal("/Dashboard", check.PageName);
            }
        }
        [Fact]
        public async void TestDetailsPageOnGetWithIDValueAndValidUser()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                RSVPUser user = new RSVPUser
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
                    PersonalRep = WhoToInheritEstate.OtherPerson
                };

                //Checking DB is actually empty
                var result = await context.Users.ToListAsync();
                Assert.Empty(result);

                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();

                var page = dm.OnGet(1);
                result = await context.Users.ToListAsync();

                Assert.Single(result);
                Assert.IsType<PageResult>(page);
            }
        }
        [Fact]
        public async void TestDetailsPageOnPostInvalidModel()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);

                //Checking DB is actually empty
                var result = await context.Users.ToListAsync();
                Assert.Empty(result);

                MockValidation.CheckValidation(dm);
                var page = await dm.OnPost();
                Assert.IsType<PageResult>(page);
            }
        }
        [Fact]
        public async void TestDetailsPageOnPostValidModelAndCheckedIn()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                RSVPUser user = new RSVPUser
                {
                    Name = "Test User",
                    Email = "fake@email",
                    PhoneNumber = "0123456789",
                    IsVeteran = true,
                    IsWashingtonResident = true,
                    PreferredTime = false,
                    ChooseMaritalStatus = MaritalStatus.FirstMarriage,
                    SpouseName = "N/A",
                    HasChildren = false,
                    IsCurrentlyPregnant = false,
                    MinorChildName = "n/a",
                    ContRemBeneficiary = WhoToInheritEstate.OtherPerson,
                    PersonToInherit = WhoToInheritEstate.OtherPerson,
                    PersonalRep = WhoToInheritEstate.OtherPerson,
                    CheckedIn = true
                };

                //Checking DB is actually empty
                var result = await context.Users.ToListAsync();
                Assert.Empty(result);

                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();
 
                result = await context.Users.ToListAsync();
                dm.ID = result[0].ID;
                dm.Name = result[0].Name;
                dm.Phone = result[0].PhoneNumber;
                dm.Email = result[0].Email;
                dm.IsVeteran = result[0].IsVeteran;
                dm.PreferredTime = result[0].PreferredTime;
                dm.IsWashingtonResident = result[0].IsWashingtonResident;
                dm.ChooseMaritalStatus = result[0].ChooseMaritalStatus;
                dm.SpouseName = result[0].SpouseName;
                dm.HasChildren = result[0].HasChildren;
                dm.IsCurrentlyPregnant = result[0].IsCurrentlyPregnant;
                dm.MinorChildName = result[0].MinorChildName;
                dm.ContRemBeneficiary = result[0].ContRemBeneficiary;
                dm.PersonToInherit = result[0].PersonToInherit;
                dm.PersonalRep = result[0].PersonalRep;
                dm.CheckedIn = result[0].CheckedIn;

                MockValidation.CheckValidation(dm);
                var page = await dm.OnPost();
                result = await context.Users.ToListAsync();

                Assert.False(result[0].CheckedIn);
                Assert.IsType<PageResult>(page);
            }
        }
        [Fact]
        public async void TestDetailsPageOnPostValidModelAndCheckedOut()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                DetailsModel dm = new DetailsModel(context);
                RSVPUser user = new RSVPUser
                {
                    Name = "Test User",
                    Email = "fake@email",
                    PhoneNumber = "0123456789",
                    IsVeteran = true,
                    IsWashingtonResident = true,
                    PreferredTime = false,
                    ChooseMaritalStatus = MaritalStatus.FirstMarriage,
                    SpouseName = "N/A",
                    HasChildren = false,
                    IsCurrentlyPregnant = false,
                    MinorChildName = "n/a",
                    ContRemBeneficiary = WhoToInheritEstate.OtherPerson,
                    PersonToInherit = WhoToInheritEstate.OtherPerson,
                    PersonalRep = WhoToInheritEstate.OtherPerson,
                    CheckedIn = false
                };

                //Checking DB is actually empty
                var result = await context.Users.ToListAsync();
                Assert.Empty(result);

                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();

                result = await context.Users.ToListAsync();
                dm.ID = result[0].ID;
                dm.Name = result[0].Name;
                dm.Phone = result[0].PhoneNumber;
                dm.Email = result[0].Email;
                dm.IsVeteran = result[0].IsVeteran;
                dm.PreferredTime = result[0].PreferredTime;
                dm.IsWashingtonResident = result[0].IsWashingtonResident;
                dm.ChooseMaritalStatus = result[0].ChooseMaritalStatus;
                dm.SpouseName = result[0].SpouseName;
                dm.HasChildren = result[0].HasChildren;
                dm.IsCurrentlyPregnant = result[0].IsCurrentlyPregnant;
                dm.MinorChildName = result[0].MinorChildName;
                dm.ContRemBeneficiary = result[0].ContRemBeneficiary;
                dm.PersonToInherit = result[0].PersonToInherit;
                dm.PersonalRep = result[0].PersonalRep;
                dm.CheckedIn = result[0].CheckedIn;

                MockValidation.CheckValidation(dm);
                var page = await dm.OnPost();
                result = await context.Users.ToListAsync();

                Assert.True(result[0].CheckedIn);
                Assert.IsType<PageResult>(page);
            }
        }
    }
}
