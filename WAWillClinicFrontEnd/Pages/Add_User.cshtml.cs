using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Pages
{
    [Authorize(Policy = "Admin")]
    [BindProperties]
    public class Add_UserModel : PageModel
    {
        private UserDbContext _context;
        [Required]
<<<<<<< HEAD
=======
        public bool Agree { get; set; }
        [Required]
>>>>>>> 7b881c05d306dec3080103bcd1da9f09070218b6
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
<<<<<<< HEAD
        public string Phone { get; set; }
=======
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
>>>>>>> 7b881c05d306dec3080103bcd1da9f09070218b6

        public Add_UserModel(UserDbContext context)
        {
            _context = context;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
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
                    ChooseMaritalStatus = ChooseMaritalStatus,
                    SpouseName = SpouseName,
                    HasChildren = HasChildren,
                    IsCurrentlyPregnant = IsCurrentlyPregnant,
                    MinorChildName = MinorChildName,
                    ContRemBeneficiary = ContRemBeneficiary,
                    PersonToInherit = PersonToInherit,
                    PersonalRep = PersonalRep,
                };
                

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Dashboard");
            }
            return Page();
        }
    }
}