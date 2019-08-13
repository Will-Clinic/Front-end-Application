using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models
{
    public class Volunteer
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public enum AttorneyPairing
        {
            [Display(Name = "I am a non-Washington licensed attorney and need to be paired with a WSBA member.")] PairWSBAMember = 1,
            [Display(Name = "I am a new practitioner/new to estate planning and would like to be paired with a mentor.")] PairMentor = 2,
            [Display(Name = "Neither of the above options apply.")] NeitherApply = 3, 
        }

        public enum Location
        {
            [Display(Name = "Kitsap/Bremerton")] Kitsap = 1,
            [Display(Name = "Pasco(Tri-Cities")] Pasco = 2,
            [Display(Name = "Seattle(North Sound)")] Seattle = 3,
            [Display(Name = "Spokane")] Spokane = 4,
            [Display(Name = "Wenatchee")] Wenatchee = 5,
        }

        public class VolunteerTime
        {
            [Display(Name = "Morning (8am-noon)")]
            public bool Morning { get; set; }
            [Display(Name = "Afternoon (1pm-5pm)")]
            public bool Afternoon { get; set; }
        }

        public enum VolunteerType
        {
            [Display(Name = "Attorney")] Attorney = 1,
            [Display(Name = "Law Student")] LawStudent = 2,
            [Display(Name = "Public Notary")] NotaryPublic = 3,
            [Display(Name = "Other/Community Member")] Other = 4,
        }

        public string AdditionalComments { get; set; }

    }
}
