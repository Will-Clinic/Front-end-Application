using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Pages
{
    [BindProperties]
    public class SignupModel : PageModel
    {
        private UserDbContext _context;
		public bool Agree { get; set; }
		public string Name { get; set; }
        public string Email { get; set; }
		public bool IsVeteran { get; set; }
		public string PhoneNumber { get; set; }
		public bool IsWashingtonResident { get; set; }
		public string PreferredTime { get; set; }
		public string SpouseName { get; set; }
		public bool HasChildren { get; set; }
		public bool IsCurrentlyPregnant { get; set; }
		public string MinorChildName { get; set; }
		//public string PersonalRep { get; set; }

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
				IsWashingtonResident = IsWashingtonResident,
				SpouseName = SpouseName,
				HasChildren = HasChildren,
				IsCurrentlyPregnant = IsCurrentlyPregnant,
				MinorChildName = MinorChildName,
				//PersonalRep = PersonalRep
			};

            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return RedirectToPage("/");
        }
    }
}