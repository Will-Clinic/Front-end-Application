using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models.ViewModels
{
    [Bind]
    public class VolunteerViewModel
    {
        [Required(ErrorMessage ="Location is Required")]
        public City VolunteerCity { get; set; }

        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Indicate Your Profession")]
        public Profession VolunteerProfession { get; set; }

        [Required(ErrorMessage = "Please Indicate Your Availability")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Please Indicate Your Pairing Needs")]
        public string Pairing { get; set; }

        public string Comments { get; set; }

        public enum City
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

        public enum Profession
        {
            [Display(Name ="Attorney")]
            Attorney,
            [Display(Name ="Law Student")]
            LawStudent,
            [Display(Name ="Notary Public")]
            NotaryPublic,
            [Display(Name ="Other/Community Member")]
            OtherCommunityMember
        }

    }
}
