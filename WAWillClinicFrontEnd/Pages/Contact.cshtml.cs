using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WAWillClinicFrontEnd.Pages
{
    [BindProperties]
    public class ContactModel : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public ContactType Reason { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }

        /// <summary>
        /// Used to create a reason select box that is easier to add or remove
        /// future reasons
        /// </summary>
        public enum ContactType
        {
            [Display(Name = "I have a question about an upcoming clinc")]
            Upcoming,
            [Display(Name = "I'd like to donate")]
            Donate,
            [Display(Name = "I am with the media and have questions")]
            Media,
            [Display(Name = "other")]
            Other
        };
    }
}