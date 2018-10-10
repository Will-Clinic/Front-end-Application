using System;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Pages;
using FrontEndTests.Utilities;
using Xunit;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndTests
{
    public class ContactUsPageTests
    {
        [Fact]
        public void ContactModelGetterAndSetterTestFirstName()
        {
            var EmailSender = new MockEmailSender();

            ContactModel contact = new ContactModel(EmailSender);

            Assert.Null(contact.FirstName);

            contact.FirstName = "Test";

            Assert.Equal("Test", contact.FirstName);
        }
        [Fact]
        public void ContactModelGetterAndSetterTestEmail()
        {
            var EmailSender = new MockEmailSender();

            ContactModel contact = new ContactModel(EmailSender);

            Assert.Null(contact.Email);

            contact.Email = "abc@123.com";

            Assert.Equal("abc@123.com", contact.Email);
        }
        [Fact]
        public void ContactModelGetterAndSetterTestPhone()
        {
            var EmailSender = new MockEmailSender();

            ContactModel contact = new ContactModel(EmailSender);

            Assert.Equal(0, contact.Phone);

            contact.Phone = 0123456789;

            Assert.Equal(0123456789, contact.Phone);
        }
        [Fact]
        public void ContactModelGetterAndSetterTestAdditionalRemarks()
        {
            var EmailSender = new MockEmailSender();

            ContactModel contact = new ContactModel(EmailSender);

            Assert.Null(contact.AdditionalRemarks);

            contact.AdditionalRemarks = "Test";

            Assert.Equal("Test", contact.AdditionalRemarks);
        }
        [Fact]
        public void ContactModelGetterAndSetterTestReason()
        {
            var EmailSender = new MockEmailSender();

            ContactModel contact = new ContactModel(EmailSender);

            Assert.Equal(EmailMessages.ContactType.UpcomingEvents, contact.Reason);

            contact.Reason = EmailMessages.ContactType.Donate;

            Assert.Equal(EmailMessages.ContactType.Donate, contact.Reason);
        }
        [Fact]
        public void ContactModelOnPostValidModelState()
        {
            var EmailSender = new MockEmailSender();

            ContactModel contact = new ContactModel(EmailSender)
            {
                FirstName = "Test Name",
                Email = "abc@123.com",
                Phone = 1234567890,
                Reason = EmailMessages.ContactType.Donate,
                AdditionalRemarks = "Additional Remarks"
            };

            //Check validity of the model
            MockValidation.CheckValidation(contact);
            var result = contact.OnPost().Result;
            RedirectToPageResult check = (RedirectToPageResult)result;
           
            Assert.Equal("/",check.PageName);
        }
        [Fact]
        public void ContactModelOnPostInvalidModelState()
        {
            var EmailSender = new MockEmailSender();

            ContactModel contact = new ContactModel(EmailSender)
            {
                FirstName = "Test Name",
                Phone = 1234567890,
                Reason = EmailMessages.ContactType.Donate,
                AdditionalRemarks = "Additional Remarks"
            };

            //Check validity of the model
            MockValidation.CheckValidation(contact);
            var result = contact.OnPost().Result;
            Assert.IsType<PageResult>(result);
        }
    }
}
