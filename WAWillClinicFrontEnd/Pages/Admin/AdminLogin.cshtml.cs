﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Pages
{
    [Authorize]
    [AllowAnonymous]
    [BindProperties]
    public class AdminLoginModel : PageModel
    {
        //Our DI fields
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IConfiguration _configuration;

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public AdminLoginModel(UserManager<ApplicationUser> userManager, 
                               SignInManager<ApplicationUser> signInManager,
                               IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public void OnGet() { }
        /// <summary>
        /// Post action that allows admins to sign in
        /// </summary>
        /// <returns>Either a page or a Redirect to another page</returns>
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var defaultPass = _configuration;
                var result = await _signInManager.PasswordSignInAsync(Email, Password, false, true);
                if(result.Succeeded)
                {
                    if(Password == _configuration["DFP"])
                    {
                        return RedirectToPage("/Admin/Change_Password");
                    }

                    var user = await _userManager.FindByEmailAsync(Email);
                    if(await _userManager.IsInRoleAsync(user, ApplicationRoles.Admin))
                    {
                        return RedirectToPage("/Admin/Dashboard");
                    }
                }
                return Page();
            }
            ModelState.AddModelError(string.Empty, "Whoops, looks like something didn't work!");
            return Page();
        }
    }
}