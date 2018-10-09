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
                dm.OnGet(null);
                Assert.Equal(0, dm.ID);
            }
        }
        //TODO: Need to add a user to the db in order to test functionality
    }
}
