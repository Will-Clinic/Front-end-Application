using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Models.Interfaces;

namespace WAWillClinicFrontEnd.Pages.Admin
{
    [Authorize(Policy = "Admin")]
    public class AdminManagerModel : PageModel
    {
        private IAdmin _adminContext;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ApplicationDbContext _context;

        public AdminManagerModel(IAdmin adminContext, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _adminContext = adminContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public void OnGet()
        {
        }
    }
}