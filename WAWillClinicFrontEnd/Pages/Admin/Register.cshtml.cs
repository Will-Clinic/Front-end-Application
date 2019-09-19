using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Models.ViewModels;

namespace WAWillClinicFrontEnd.Pages.Admin
{
    public class RegisterModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ApplicationDbContext _context;



        [BindProperty]
        public RegisterViewModel Input { get; set; }
        public string ReturnUrl { get; set; }


        public RegisterModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var admin = new ApplicationUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,

                };

                var result = await _userManager.CreateAsync(admin, Input.Password);

                if (result.Succeeded)
                {
                    Claim fullNameClaim = new Claim("Full Name", $"{admin.FirstName} {admin.LastName}");
                    Claim emailClaim = new Claim(ClaimTypes.Email, admin.Email, ClaimValueTypes.Email);

                    List<Claim> adminClaims = new List<Claim>
                    {
                        fullNameClaim,
                        emailClaim
                    };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity();
                    claimsIdentity.AddClaims(adminClaims);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
                    claimsPrincipal.AddIdentity(claimsIdentity);
                    await _userManager.AddClaimsAsync(admin, adminClaims);

                    if (admin.Email.ToLower().Contains("@admin.com"))
                    {
                        await _userManager.AddToRoleAsync(admin, ApplicationRoles.Admin);
                    }

                    await _userManager.AddToRoleAsync(admin, ApplicationRoles.Member);


                    await _signInManager.SignInAsync(admin, isPersistent: false);
                    await _context.SaveChangesAsync();

                    return LocalRedirect(returnUrl);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return Page();
        }
    }
}