using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Pages
{
    [Authorize(Policy = "Admin")]
    [BindProperties]
    public class DashboardModel : PageModel
    {
        private UserDbContext _context;
        public List<RSVPUser> Users { get; set; } = new List<RSVPUser>();
        public DashboardModel(UserDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Action that grabs all of our registered users within the
        /// database or a subset of users based on a search for name
        /// </summary>
        /// <returns>Page</returns>
        public async Task OnGet(string searchString)
        {
            // defines a base query to work with, but does not run it
            // against the db yet
            var users = from u in _context.Users
                        select u;

            // filter if user searches by name
            if (!String.IsNullOrEmpty(searchString))
            {
                users = _context.Users.
                    Where(u => u.Name.ToLower().Contains(searchString.ToLower()));
            }

            // formats query (or default list) into a list format to display on the page
            Users = await users.ToListAsync();
        }
    }
}