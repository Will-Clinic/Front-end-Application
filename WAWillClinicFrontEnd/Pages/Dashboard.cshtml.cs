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
        /// database
        /// </summary>
        /// <returns>Page</returns>
        public async Task OnGet()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}