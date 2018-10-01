using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models
{
    public class RSVPUser
    {
        public int ID { get; set; }

        // 1) Full legal name (pretty please)
        [Required]
        public string Name { get; set; }

        // 2) Address (not required)
        public string Address { get; set; }

        // 3) Phone Number (pretty please)
        [Required]
        public string PhoneNumber { get; set; }

        // 4) Email address (pretty please)
        [Required]
        public string Email { get; set; }

        // 5) Are you or your spouse a Veteran of
        // the United States Armed Forces? (not required)
        // NOTE: could make this either enum or bool
        // (Andrew used public bool? VeteranStatus for this)
        public YesNoQues VeteranOrNot { get; set; }

        // 6) Do you have proof of military service? (not required)
        [Required]
        public YesNoQues HaveMilitaryService { get; set; }

        // 7) Are you a Washington state resident? (pretty please)
        [Required]
        public YesNoQues IsWashingtonResident { get; set; }

        // 8) Is your net worth less than $500,000
        //($1,000,000 per married couple)? (pretty please)
        [Required]
        public YesNoQues IsNetWorthLowEnough { get; set; }

        // 9) Please indicate your preferred time to receive service. (not required)
        // ?? Bob Saget. How do we want to deal with checkboxes?

        // 19) Marital status (not required) 
        public MaritalStatus ChooseMaritalStatus { get; set; }

        // 20) Full legal name of your spouse (pretty please)
        // might make a note to write N/A or leave blank
        [Required]
        public string SpouseName { get; set; }

        // 21) Do you have any children? (not required)
        public YesNoQues HaveChildren { get; set; }

        // 22) Do you have any minor children? Or 
        // are you, your spouse, or your partner currently
        // pregnant? (pretty please)
        [Required]
        public YesNoQues CurrentlyPregnant { get; set; }

        public enum YesNoQues
        {
            Yes = 1,
            No = 2
        }

        public enum TimeForService
        {
            Morning = 1,
            Afternoon = 2
        }

        public enum MaritalStatus
        {
            [Display(Name = "Single (divorced)")] SingleAndDivorced = 1,
            [Display(Name = "Single (divorced)")] SingleAndNeverDivorced = 2,
            [Display(Name = "Presently married, and had a prior marriage " +
                "(previous spouse is deceased or legally divorced)")] SecondMarriage = 3,
            [Display(Name = "Married and my spouse is alive. No previous marriage.")] FirstMarriage = 4,
            [Display(Name = "Widowed")] Widowed = 5
        }
    }
}
