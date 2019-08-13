using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WAWillClinicFrontEnd.Pages
{
    public class LocationChoiceModel : PageModel
    {
        [BindProperty]
        public Location LocationChoice { get; set; }

        public enum Location
        {
            [Display(Name = "Pasco(Tri-Cities")]
            Pasco,
            [Display(Name = "Wenatchee")]
            Wenatchee,
            [Display(Name = "Seattle(North Sound)")]
            Seattle,
            [Display(Name = "Kitsap/Bremerton")]
            Kitsap
        }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Location location = LocationChoice;
            return RedirectToPage("Signup", location);
        }
    }
}