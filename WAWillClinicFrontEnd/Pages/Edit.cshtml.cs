using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Pages
{
    [Authorize(Policy = "Admin")]
    [BindProperties]
    public class EditModel : PageModel
    {
        private UserDbContext _context;

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public bool IsVeteran { get; set; }
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
        public EditModel(UserDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Our Get Action that checks if the given id is null or empty.
        /// It then checks to see if a user exists and populates the
        /// properties
        /// </summary>
        /// <param name="id">Identity id</param>
        /// <returns>Page or Redirect</returns>
        public void OnGet(int? id)
        {
            if (id.HasValue)
            {
                var user = _context.Users.FirstOrDefault(i => i.ID == id);

                if (user == null) RedirectToPage("/Dashboard");
                Name = user.Name;
                Phone = user.PhoneNumber;
                Email = user.Email;
                IsVeteran = user.IsVeteran;
                PreferredTime = user.PreferredTime;
                IsWashingtonResident = user.IsWashingtonResident;
                ChooseMaritalStatus = user.ChooseMaritalStatus;
                SpouseName = user.SpouseName;
                HasChildren = user.HasChildren;
                IsCurrentlyPregnant = user.IsCurrentlyPregnant;
                MinorChildName = user.MinorChildName;
                ContRemBeneficiary = user.ContRemBeneficiary;
                PersonToInherit = user.PersonToInherit;
                PersonalRep = user.PersonalRep;
            }
            RedirectToPage("/Dashboard");
        }
        /// <summary>
        /// Our Action that allows admins to update the specific
        /// user they are seeing
        /// </summary>
        /// <returns>Page or Redirect</returns>
        public async Task<IActionResult> OnPost()
        {
            var user = _context.Users.FirstOrDefault(i => i.ID == ID);
            if (ModelState.IsValid)
            {
                user.Name = Name;
                user.PhoneNumber = Phone;
                user.Email = Email;
                user.IsVeteran = IsVeteran;
                user.PreferredTime = PreferredTime;
                user.IsWashingtonResident = IsWashingtonResident;
                user.ChooseMaritalStatus = ChooseMaritalStatus;
                user.SpouseName = SpouseName;
                user.HasChildren = HasChildren;
                user.IsCurrentlyPregnant = IsCurrentlyPregnant;
                user.MinorChildName = MinorChildName;
                user.ContRemBeneficiary = ContRemBeneficiary;
                user.PersonToInherit = PersonToInherit;
                user.PersonalRep = PersonalRep;

                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Dashboard");
            }
            return Page();
        }
        /// <summary>
        /// Action to delete the specific user
        /// </summary>
        /// <returns>Page</returns>
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            var user = await _context.Users.FirstOrDefaultAsync(e => e.Email == Email);
            if (user != null)
            {
                return RedirectToPage("/DeleteConfirm", user.ID);
            }
            return Page();
        }
    }
}