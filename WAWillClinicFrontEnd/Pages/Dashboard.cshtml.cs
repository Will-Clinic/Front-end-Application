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
        public string SearchString { get; set; }
		public int TotalCheckedIn { get; set; }
		public int TotalSignUp { get; set; }
		public bool WantsToSeeCheckedIn { get; set; }

		public DashboardModel(UserDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Action that grabs all of our registered users within the
        /// database or a subset of users based on a search for name
        /// </summary>
        /// <returns>Page</returns>
        public async Task OnGet(string searchString, bool isCheckedIn)
        {
            // defines a base query to work with, but does not run it
            // against the db yet
            var users = from u in _context.Users
                        select u;

            // filter if user searches by name
            if (!String.IsNullOrEmpty(searchString))
            {
				//if (searchString == "checked in" || "check in")
				//{
				//}
                users = _context.Users.
                    Where(u => u.Name.ToLower().Contains(searchString.ToLower()));
                SearchString = searchString;

            }

			//show only checked in users
			if (isCheckedIn)
			{
				users = _context.Users.Where(u => u.CheckedIn == true);
			}

			WantsToSeeCheckedIn = isCheckedIn;

			// formats query (or default list) into a list format to display on the page
			Users = await users.ToListAsync();

			//total count for sign up and checked in query
			TotalSignUp = Users.Count();
			TotalCheckedIn = Users.Where(c => c.CheckedIn == true).Count();
        }
    }
}