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

namespace WAWillClinicFrontEnd.Pages
{
    [Authorize(Policy = "Admin")]
    [BindProperties]
    public class Add_UserModel : PageModel
    {
        private UserDbContext _context;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

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
                    Name = Name,
                    Email = Email,
                    PhoneNumber = Phone
                };

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Dashboard");
            }
            return Page();
        }
    }
}