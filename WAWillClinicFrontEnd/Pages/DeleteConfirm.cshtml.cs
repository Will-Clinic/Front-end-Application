using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WAWillClinicFrontEnd.Data;

namespace WAWillClinicFrontEnd.Pages
{
    [Authorize(Policy = "Admin")]
    [BindProperties]
    public class DeleteConfirmModel : PageModel
    {
        private UserDbContext _context;

        public int ID { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public DeleteConfirmModel(UserDbContext context)
        {
            _context = context;
        }

        public void OnGet(int? id)
        {
            if (id.HasValue)
            {
                var user = _context.Users.FirstOrDefault(u => u.ID == id);
                if (user == null) RedirectToPage("/Dashboard");
                ID = user.ID;
                Email = user.Email;
                Name = user.Name;
            }

            RedirectToPage("/Dashboard");
        }

        /// <summary>
        /// Action to delete the specific user
        /// </summary>
        /// <returns>Page</returns>
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.ID == ID);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Dashboard");
        }
    }
}