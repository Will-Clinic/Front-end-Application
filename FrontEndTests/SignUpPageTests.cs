using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WAWillClinicFrontEnd.Pages;
using WAWillClinicFrontEnd.Data;
using FrontEndTests.Utilities;
using WAWillClinicFrontEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndTests
{
    public class SignUpPageTests
    {
        [Fact]
        public void TestSignUpPageGetterAndSetterAgree()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.False(sum.Agree);

                sum.Agree = true;
                Assert.True(sum.Agree);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.Null(sum.Name);

                sum.Name = "Test Name";
                Assert.Equal("Test Name", sum.Name);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterEmail()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.Null(sum.Email);

                sum.Email = "abc@123.com";
                Assert.Equal("abc@123.com", sum.Email);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterPhone()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.Null(sum.PhoneNumber);

                sum.PhoneNumber = "0123456789";
                Assert.Equal("0123456789", sum.PhoneNumber);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterIsVeteran()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.False(sum.IsVeteran);

                sum.IsVeteran = true;
                Assert.True(sum.IsVeteran);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterIsWashingtonResident()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.False(sum.IsWashingtonResident);

                sum.IsWashingtonResident = true;
                Assert.True(sum.IsWashingtonResident);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterPreferredTime()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.False(sum.PreferredTime);

                sum.PreferredTime = true;
                Assert.True(sum.PreferredTime);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterMaritalStatus()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender)
                {
                    ChooseMaritalStatus = MaritalStatus.FirstMarriage
                };

                Assert.Equal(MaritalStatus.FirstMarriage, sum.ChooseMaritalStatus);
                sum.ChooseMaritalStatus = MaritalStatus.SecondMarriage;
                Assert.Equal(MaritalStatus.SecondMarriage, sum.ChooseMaritalStatus);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterSpouseName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.Null(sum.SpouseName);

                sum.SpouseName = "Test Name";
                Assert.Equal("Test Name", sum.SpouseName);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterHasChildren()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.False(sum.HasChildren);

                sum.HasChildren = true;
                Assert.True(sum.HasChildren);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterCurrentlyPregnant()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.False(sum.IsCurrentlyPregnant);

                sum.IsCurrentlyPregnant = true;
                Assert.True(sum.IsCurrentlyPregnant);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterMinorChildName()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender);
                Assert.Null(sum.MinorChildName);

                sum.MinorChildName = "Test Name";
                Assert.Equal("Test Name", sum.MinorChildName);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterContRemBeneficiary()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender)
                {
                    ContRemBeneficiary = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, sum.ContRemBeneficiary);

                sum.ContRemBeneficiary = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, sum.ContRemBeneficiary);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterPersonToInherit()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender)
                {
                    PersonToInherit = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, sum.PersonToInherit);

                sum.PersonToInherit = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, sum.PersonToInherit);
            }
        }
        [Fact]
        public void TestSignUpPageGetterAndSetterPersonalRep()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender)
                {
                    PersonalRep = WhoToInheritEstate.ComplicatedChildren
                };
                Assert.Equal(WhoToInheritEstate.ComplicatedChildren, sum.PersonalRep);

                sum.PersonalRep = WhoToInheritEstate.OtherPerson;
                Assert.Equal(WhoToInheritEstate.OtherPerson, sum.PersonalRep);
            }
        }

        [Fact]
        public async void TestSignUpPageWithInvalidModelState()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender)
                {
                    Name = "Test Name",
                    Email = "fake@email",
                    IsVeteran = true
                };

                //Checking DB is actually empty
                var result = await context.Users.ToListAsync();
                Assert.Empty(result);

                MockValidation.CheckValidation(sum);
                var page = sum.OnPost().Result;
                Assert.IsType<PageResult>(page);
            }
        }
        [Fact]
        public async void TestSignUpPageWithValidModelState()
        {
            using (var context = new UserDbContext(MockRSVPUserDb.TestRSVPDbContextOptions()))
            {
                MockEmailSender EmailSender = new MockEmailSender();
                SignupModel sum = new SignupModel(context, EmailSender)
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

                MockValidation.CheckValidation(sum);
                var page = sum.OnPost().Result;
                RedirectToPageResult check = (RedirectToPageResult)page;
                result = await context.Users.ToListAsync();

                Assert.Single(result);
                Assert.Equal("SignUpConformation", check.PageName);
            }
        }
    }
}
