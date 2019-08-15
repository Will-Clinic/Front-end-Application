using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Models.Interfaces;
using WAWillClinicFrontEnd.Models.ViewModels;

namespace WAWillClinicFrontEnd.Pages
{
    public class VolunteerModel : PageModel
    {
        private readonly IVolunteer _volunteer;
        private readonly IEmailSender _emailSender;

        public VolunteerModel(IVolunteer volunteer, IEmailSender emailSender)
        {
            _volunteer = volunteer;
            _emailSender = emailSender; 
        }

        [BindProperty]
        public Volunteer Input { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var volunteer = new Volunteer
                {
                    VolunteerCity = Input.VolunteerCity,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    EmailAddress = Input.EmailAddress,
                    PhoneNumber = Input.PhoneNumber,
                    Profession = Input.Profession,
                    VolunteerTimeMorning = Input.VolunteerTimeMorning,
                    VolunteerTimeAfternoon = Input.VolunteerTimeAfternoon,
                    MemberPair = Input.MemberPair,
                    MentorPair = Input.MentorPair,
                    Nopair = Input.Nopair,
                    AdditionalComments = Input.AdditionalComments
                };

                await _volunteer.CreateVolunteer(volunteer);
                await _emailSender.SendEmailAsync(volunteer.EmailAddress, EmailMessages.Thanks, EmailMessages.VolunteerRepy(volunteer));
            }


            return Page();
        }
    }
}