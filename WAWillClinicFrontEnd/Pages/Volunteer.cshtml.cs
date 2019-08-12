using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WAWillClinicFrontEnd.Pages
{
    public class VolunteerModel : PageModel
    {
        public City VolunteerCity { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phonenumber { get; set; }

        public Profession VolunteerProfession { get; set; }

        public string Time { get; set; }

        public string Pairing { get; set; }

        public string Comments { get; set; }

        public enum City
        {

        }

        public enum Profession
        {
            [Display(Name = "Pasco(Tri-Cities")]
            Pasco,
            [Display(Name ="Wenatchee")]
            Wenatchee,
            [Display(Name ="Seattle(North Sound")]
            Seattle,
            [Display(Name ="Kitsap/Bremerton")]
            Kitsap
    }


        public void OnGet()
        {
        }
    }
}