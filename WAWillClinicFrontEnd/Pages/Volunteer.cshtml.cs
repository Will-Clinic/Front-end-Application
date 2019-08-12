using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Models.ViewModels;

namespace WAWillClinicFrontEnd.Pages
{
    public class VolunteerModel : PageModel
    {
        [BindProperty]
        public VolunteerViewModel Input { get; set; }

        public void OnGet()
        {
        }
    }
}