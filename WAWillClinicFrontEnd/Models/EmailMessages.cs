using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WAWillClinicFrontEnd.Pages;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models
{
    /// <summary>
    /// This class is used to create and format specific email messages.
    /// </summary>
    public class EmailMessages
    {
        /// <summary>
        /// Message that is sent to the requestor from the Contact page.
        /// </summary>
        /// <param name="contact">Takes in a Razor Page Object to grab the needed properties</param>
        /// <returns>string</returns>
        public static string ContactUsReply(ContactModel contact)
        {
            StringBuilder message = new StringBuilder();

            message.Append($"<p>Thanks for reaching out to us {contact.FirstName} {contact.LastName}</p>");
            message.Append("<br />");
            message.Append("<p>We will be in touch with you soon!</p>");

            return message.ToString();
        }
        /// <summary>
        /// Message that is sent from the site to inform admins that contact information
        /// has been requested
        /// </summary>
        /// <param name="contact">Takes in a Razor Page Object to grab the needed properties</param>
        /// <returns></returns>
        public static string ContactUsRequest(ContactModel contact)
        { 
            StringBuilder message = new StringBuilder();



            return message.ToString();
        }

        /// <summary>
        /// Used to create a reason select box that is easier to add or remove
        /// future reasons
        /// </summary>
        public enum ContactType
        {
            [Display(Name = "")]
            Empty,
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
