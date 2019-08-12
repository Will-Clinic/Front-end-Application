using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models.ViewModels
{
    public class VolunteerViewModel
    {
        public City VolunteerCity { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Profession VolunteerProfession { get; set; }

        public string Time { get; set; }

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
