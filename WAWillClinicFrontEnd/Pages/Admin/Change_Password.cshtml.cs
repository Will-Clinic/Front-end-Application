using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class Change_PasswordModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

        public Change_PasswordModel(UserManager<ApplicationUser> userManager,
                                    SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public void OnGet() { }
        /// <summary>
        /// Action that confirms if passwords match and proceeds to 
        /// find the current user and change the password
        /// </summary>
        /// <returns>Page or Redirect</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (ConfirmPassword != Password) return Page();
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(Name);
                if(user != null)
                {
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, ConfirmPassword);
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded) return RedirectToPage("/Admin/Dashboard");
                    return Page();
                }
                return Page();
            }
            return Page();
        }
    }
}