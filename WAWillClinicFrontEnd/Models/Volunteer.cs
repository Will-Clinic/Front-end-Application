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


        public bool MemberPair { get; set; }

        public bool MentorPair { get; set; }

        public bool Nopair { get; set; }

        [Required]
        public VolunteerCity VolunteerCity { get; set; }
        
        [Display(Name = "Morning (8am-noon)")]
        public bool VolunteerTimeMorning { get; set; }
        [Display(Name = "Afternoon (1pm-5pm)")]
        public bool VolunteerTimeAfternoon { get; set; }
        
        [Required]
        public VolunteerType Profession { get; set; }
        
        public string AdditionalComments { get; set; }

    }


    public enum VolunteerCity
    {
        [Display(Name = "Kitsap/Bremerton")] Kitsap = 1,
        [Display(Name = "Pasco(Tri-Cities")] Pasco = 2,
        [Display(Name = "Seattle(North Sound)")] Seattle = 3,
        [Display(Name = "Spokane")] Spokane = 4,
        [Display(Name = "Wenatchee")] Wenatchee = 5,
    }

    public enum VolunteerType
    {
        [Display(Name = "Attorney")] Attorney = 1,
        [Display(Name = "Law Student")] LawStudent = 2,
        [Display(Name = "Public Notary")] NotaryPublic = 3,
        [Display(Name = "Other/Community Member")] Other = 4,
    }
}
