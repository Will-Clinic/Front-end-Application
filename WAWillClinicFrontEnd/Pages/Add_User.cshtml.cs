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
    public class Add_UserModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        public Add_UserModel(UserManager<ApplicationUser> userManager,
                             SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                Guid password = Guid.NewGuid();
                var user = new ApplicationUser()
                {
                    UserName = Email,
                    Email = Email,
                    FirstName = FirstName,
                    LastName = LastName,
                    PhoneNumber = Phone.ToString()
                };

                var result = await _userManager.CreateAsync(user, password.ToString()+"A");
                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, ApplicationRoles.Member);
                    return RedirectToPage("/Dashboard");
                }
                return Page();
            }
            return Page();
        }
    }
}