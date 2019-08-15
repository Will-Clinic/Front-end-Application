using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models;
using static WAWillClinicFrontEnd.Models.RSVPUser;

namespace WAWillClinicFrontEnd.Pages
{
    [BindProperties]
    public class SignupModel : PageModel
    {
        private UserDbContext _context;
        private IEmailSender _emailSender;

        public City Location { get; set; }
        [Required]
		public bool Agree { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public bool IsVeteran { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		public bool IsWashingtonResident { get; set; }
		[Required]
		public bool PreferredTime { get; set; }
		[Required]
		public MaritalStatus ChooseMaritalStatus { get; set; }
		[Required]
		public string SpouseName { get; set; }
		[Required]
		public bool HasChildren { get; set; }
		[Required]
		public bool IsCurrentlyPregnant { get; set; }
		[Required]
		public string MinorChildName { get; set; }
		[Required]
		public WhoToInheritEstate ContRemBeneficiary { get; set; }
		[Required]
        public WhoToInheritEstate PersonToInherit { get; set; }
		[Required]
		public WhoToInheritEstate PersonalRep { get; set; }
		//[Required]
		//public WhoToInheritEstate BackupRep { get; set; }


		public SignupModel(UserDbContext context, IEmailSender emailSender)
        {
            _context = context;
            _emailSender = emailSender;
        }

		public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                RSVPUser user = new RSVPUser()
                {
                    Location = Location,
                    Agree = Agree,
                    Name = Name,
                    Email = Email,
                    PhoneNumber = PhoneNumber,
                    IsVeteran = IsVeteran,
                    PreferredTime = PreferredTime,
                    IsWashingtonResident = IsWashingtonResident,
                    ChooseMaritalStatus = ChooseMaritalStatus,
                    SpouseName = SpouseName,
                    HasChildren = HasChildren,
                    IsCurrentlyPregnant = IsCurrentlyPregnant,
                    MinorChildName = MinorChildName,
                    ContRemBeneficiary = ContRemBeneficiary,
                    PersonToInherit = PersonToInherit,
                    PersonalRep = PersonalRep,
                    //BackupRep = BackupRep,
                };
                //if (PersonalRep == BackupRep)
                //{
                //	TempData["Error"] = "Please make sure your Personal Rep is not the same as your Backup Rep."; 
                //	return Page();
                //}
                if (!Agree)
                {
                    TempData["Error"] = "You cannot sign up unless you agree to the terms and conditions.";
                    return Page();
                }
                await _context.AddAsync(user);
                await _context.SaveChangesAsync();
                await _emailSender.SendEmailAsync(Email,
                       EmailMessages.Thanks,
                       EmailMessages.SignUpReply(user));

                return RedirectToPage("SignUpConformation");
            }
            return Page();
        }
    }
}