using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models
{
    public class EmailSender : IEmailSender
    {
        IConfiguration _configuration { get; }

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(_configuration["SendGridAPI"]);
            var msg = new SendGridMessage();

            msg.SetFrom("test@email.com", "Test Email");
            msg.AddTo(email);
            msg.SetSubject(subject);
            msg.AddContent(MimeType.Html, htmlMessage);

            var response =  await client.SendEmailAsync(msg);
        }
    }
}
