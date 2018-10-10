using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndTests.Utilities
{
    class MockEmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient("");
            var msg = new SendGridMessage();

            msg.SetFrom("unit.test@email.com", "developer");
            msg.AddTo(email);
            msg.SetSubject(subject);
            msg.AddContent(MimeType.Html, htmlMessage);

            await Task.CompletedTask;
        }
    }
}
