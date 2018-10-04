using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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
		public string PreferredTime { get; set; }
		[Required]
		public string SpouseName { get; set; }
		[Required]
		public bool HasChildren { get; set; }
		[Required]
		public bool IsCurrentlyPregnant { get; set; }
		[Required]
		public string MinorChildName { get; set; }

        [Required]
        public WhoToInheritEstate PersonToInherit { get; set; }

		[Required]
		public WhoToInheritEstate PersonalRep { get; set; }
		[Required]
		public WhoToInheritEstate BackupRep { get; set; }

		public SignupModel(UserDbContext context)
        {
            _context = context;
        }

		public void OnGet() { }

        public async Task<IActionResult> OnPost()
        {
			RSVPUser user = new RSVPUser()
			{
				Agree = Agree,
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
				IsVeteran = IsVeteran,
                PreferredTime = PreferredTime,
                IsWashingtonResident = IsWashingtonResident,
				SpouseName = SpouseName,
				HasChildren = HasChildren,
				IsCurrentlyPregnant = IsCurrentlyPregnant,
				MinorChildName = MinorChildName,
                PersonToInherit = PersonToInherit,
                PersonalRep = PersonalRep,
				BackupRep = BackupRep,
            };

			if (PersonalRep == BackupRep)
			{
				TempData["Error"] = "Please make sure your Personal Rep is not the same as your Backup Rep."; 
				return Page();
			}
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return RedirectToPage("/");
        }
    }
}