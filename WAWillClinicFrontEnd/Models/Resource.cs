using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models
{
    public class Resource
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public string Description { get; set; }

        public enum ResourceType
        {
            [Display(Name = "Health Care")] HealthCare = 1,
            [Display(Name = "Family")] Family = 2,
            [Display(Name = "Disability")] Disability = 3,
            [Display(Name = "Education")] Education = 4,
            [Display(Name = "Finance")] Finance = 5,
            [Display(Name = "Other")] Other = 6,
        }

    }
}
