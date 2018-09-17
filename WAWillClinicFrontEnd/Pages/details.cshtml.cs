using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Pages
{
    [Authorize(Policy = "Admin")]
    [BindProperties]
    public class DetailsModel : PageModel
    {
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DetailsModel(UserManager<ApplicationUser> userManager,
                            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        /// <summary>
        /// Our Get Action that checks if the given id is null or empty.
        /// It then checks to see if a user exists and populates the
        /// properties
        /// </summary>
        /// <param name="id">Identity id</param>
        /// <returns>Page or Redirect</returns>
        public async Task OnGet(string id)
        {
            if(!string.IsNullOrEmpty(id))
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user == null) RedirectToPage("/Dashboard");
                FirstName = user.FirstName;
                LastName = user.LastName;
                Phone = user.PhoneNumber;
                Email = user.Email;
            }
        }
        /// <summary>
        /// Our Action that allows admins to update the specific
        /// user they are seeing
        /// </summary>
        /// <returns>Page or Redirect</returns>
        public async Task<IActionResult> OnPost()
        {
            var user = await _userManager.FindByEmailAsync(Email);
            if(ModelState.IsValid)
            {
                user.FirstName = FirstName;
                user.LastName = LastName;
                user.PhoneNumber = Phone;
                user.Email = Email;

                await _userManager.UpdateAsync(user);
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
            var user = await _userManager.FindByEmailAsync(Email);
            if(user != null)
            {
                await _userManager.DeleteAsync(user);
                return RedirectToPage("/Dashboard");
            }
            return Page();
        }
    }
}