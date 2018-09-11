using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WAWillClinicFrontEnd.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WAWillClinicFrontEnd.Pages
{
    [BindProperties]
    public class ContactModel : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public EmailMessages.ContactType Reason { get; set; }
        public string AdditionalRemarks { get; set; }

        private IEmailSender _emailSender;

        public ContactModel(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            //Work around to prevent empty selection
            if (Reason == EmailMessages.ContactType.Empty) return Page();

            if(ModelState.IsValid)
            {
                await _emailSender.SendEmailAsync(Email, 
                       "WA Vets Will Clinic - Thank you!", 
                       EmailMessages.ContactUsReply(this));
                return RedirectToPage("/");
            }
            //equiv to return View();
            return Page();
        }
    }
}