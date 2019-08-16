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
        public string ImageName { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public ResourceType Type { get; set; }
    }

    public enum ResourceType
    {
        [Display(Name = "Disability")] Disability = 1,
        [Display(Name = "Education")] Education = 2,
        [Display(Name = "Family")] Family = 3,
        [Display(Name = "Finance")] Finance = 4,
        [Display(Name = "Health Care")] HealthCare = 5,
        [Display(Name = "Other")] Other = 6,
    }
}