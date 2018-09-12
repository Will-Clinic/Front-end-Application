﻿using System;
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
        /// Properties that are used for our email subject headings
        /// </summary>
        public static string Thanks { get; } = "WA Vets Will Clinic - Thank you!";
        public static string Request { get; } = "Information Request - WA Vets Will Clinic";

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

            message.Append("<h3>The following information has been requested: </h3>");
            message.Append($"<p>&nbsp;Reason: {contact.Reason}</p>");
            message.Append($"<p>&nbsp;Name: {contact.FirstName} {contact.LastName}</p>");
            message.Append($"<p>&nbsp;Email: {contact.Email}</p>");
            message.Append($"<p>&nbsp;Phone Number: {contact.Phone}</p>");
            message.Append("<br />");
            message.Append("<h3>Additional Information/Remarks</h3>");
            message.Append($"<p>&nbsp;{contact.AdditionalRemarks}</p>");

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
            UpcomingEvents,
            [Display(Name = "I'd like to donate")]
            Donate,
            [Display(Name = "I am with the media and have questions")]
            Media,
            [Display(Name = "other")]
            Other
        };
    }
}
