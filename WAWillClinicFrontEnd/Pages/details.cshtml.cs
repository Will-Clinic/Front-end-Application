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
    public class DetailsModel : PageModel
    {
        private UserDbContext _context;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

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
        public void OnGet(int? id)
        {
            if(id.HasValue)
            {
                var user = _context.Users.FirstOrDefault(i => i.ID == id);

                if (user == null) RedirectToPage("/Dashboard");
                Name = user.Name;
                Phone = user.PhoneNumber;
                Email = user.Email;
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
            var user = _context.Users.FirstOrDefault(e => e.Email == Email);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Dashboard");
            }
            return Page();
        }
    }
}