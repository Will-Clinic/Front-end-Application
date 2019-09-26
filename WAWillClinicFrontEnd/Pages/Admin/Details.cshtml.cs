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
    public class DetailsModel : PageModel
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
        [Required]
        public bool CheckedIn { get; set; }

        public DetailsModel(UserDbContext context)
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
        public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
            {
                var user = _context.Users.FirstOrDefault(i => i.ID == id);

                if (user == null) return RedirectToPage("/Dashboard");
                ID = user.ID;
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
                CheckedIn = user.CheckedIn;
                return Page();
            }
            return RedirectToPage("/Dashboard");
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
                if (user.CheckedIn)
                {
                    user.CheckedIn = false;
                    CheckedIn = user.CheckedIn;
                }
                else
                {
                    user.CheckedIn = true;
                    CheckedIn = user.CheckedIn;
                }
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("/Admin/Dashboard");
        }
    }
}