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

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public bool IsVeteran { get; set; }
		public bool HasProofOfService { get; set; }
		public bool IsWashingtonResident { get; set; }
		public bool IsNetWorthLowEnough { get; set; }
		public string PreferredTime { get; set; }

		public SignupModel(UserDbContext context)
        {
            _context = context;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPost()
        {
            RSVPUser user = new RSVPUser()
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
				Address = Address,
				IsVeteran = IsVeteran,
				HasProofOfService = HasProofOfService,
				IsWashingtonResident = IsWashingtonResident,
				IsNetWorthLowEnough = IsNetWorthLowEnough
			};

            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return RedirectToPage("/");
        }
    }
}