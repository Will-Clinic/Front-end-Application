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

		[Required]
		public bool? Agree { get; set; }

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
        public bool IsVeteran { get; set; }

        // 6) Do you have proof of military service? (not required)
        //[Required]
        //public bool? HasProofOfService { get; set; }

        // 7) Are you a Washington state resident? (pretty please)
        [Required]
        public bool IsWashingtonResident { get; set; }

        // 8) Is your net worth less than $500,000
        //($1,000,000 per married couple)? (not required)
        //public bool? IsNetWorthLowEnough { get; set; }

        // 9) Please indicate your preferred time to receive service. (not required)
        public bool PreferredTime { get; set; }

        // 19) Marital status (not required) 
		[Required]
        public MaritalStatus ChooseMaritalStatus { get; set; }

        // 20) Full legal name of your spouse (pretty please)
        // might make a note to write N/A or leave blank
        [Required]
        public string SpouseName { get; set; }

        // 21) Do you have any children? (not required)
        public bool HasChildren { get; set; }

        // 22) Do you have any minor children? Or 
        // are you, your spouse, or your partner currently
        // pregnant? (pretty please)
        [Required]
        public bool IsCurrentlyPregnant { get; set; }

        //23) If you have minor children, AND the parent of
        //your minor child is DIFFERENT from your current
        //spouse, please list them below. (not required)
        public string ChildsParentNotYourSpouse { get; set; }

        // 20) Full legal name(s) of your MINOR child(ren) (pretty please)
        // NOTE: even though it's pretty please, do we really make this required?
        // Perhaps make some dependency on the answer to the last question.
        public string MinorChildName { get; set; }

        // 25) Would you like to make any specific bequests? (not required)
        public bool? HasSpecialRequest { get; set; }

        // 26) If you answered YES:
        // NOTE: We could simplify 25 and 26 and just make it one text box
        public string SpecialRequest { get; set; }

        //27) Who would you like to inherit your estate when you die? 
        //Please check one: (pretty please)
        [Required]
        public WhoToInheritEstate PersonToInherit { get; set; }

		//29) Contigent Remainder Beneficiary
		[Required]
		public WhoToInheritEstate ContRemBeneficiary { get; set; }

		//30) If you selected a specific charity or person(s) to be your
		//    
		//public string ContRemBeneficiary { get; set; }

        // 31) Would you like to disinherit someone, other than your spouse?
        // (not required)
        public bool WantsToDisInherit { get; set; }

        // 32) If you have chosen to disinherit someone, other than your spouse,
        //    please provide their full legal name and relationship to you.
        // (not required) NOTE: could also squeeze this into one question
        public string DisinheritPerson { get; set; }

        // 33) If you'd like to appoint a guardian, please list their name,
        //    city, and state of residence. (Example: John Doe, Spokane,
        //        Washington) (gee, it would be swell)
        public string GuardianName { get; set; }

        // 34) If you'd like to appoint an alternate guardian, in the event the
        //    above guardian(s) are unavailable, you may do so by listing
        //    their name, city, and state of residence below. (Example: John
        //    Doe, Spokane, Washington) (gee, it would be swell)
        public string AlternateGuardianName { get; set; }

        // 35) Whom do you wish to serve as your personal representative?
        // NOTE: The answers to this don't make sense! The choices are the same as that
        // of question 27. Wut? (pretty please)
        [Required]
        public WhoToInheritEstate PersonalRep { get; set; }

        //36) Whom do you wish to serve as an alternate if your
        //    first choice for personal representative is unable to serve? (pretty please)
        //[Required]
        //public WhoToInheritEstate BackupRep { get; set; }

        // 37) Would you like a General Power of Attorney? (not required)
        public bool LikesGenPoA { get; set; }

        // 38) Who would you like to serve as your attorney-in-fact? (not required)
        public string AttorneyInFact { get; set; }

        // 39) If you would like to name a successor attorney-in-fact, in case your
        // first choice is unable to serve, please list them below: (not required)
        public string SuccessorAttorneyInFact { get; set; }

        // 40) Do you want a health care directive? (not required)
        public bool WantHealthCareDirective { get; set; }

        // 41) Hydration: (not required)
        public string Hydration { get; set; }

        // 42) Nutrition: (not required)
        public string Nutrition { get; set; }

        // 43) Cardiopulmonary resuscitation / assisted ventilation: (not required)
        public string CardioAssistance { get; set; }

        // 44) Pain / distress medication: (not required)
        public string PainMeds { get; set; }

        // 45) Would you like a health care power of attorney? (not required)
        public bool LikesPoA { get; set; }

        // 46) Who would you like to serve as your attorney-in-fact for health
        // care decisions? (not required)
        public string HealthCareAIF { get; set; }

        // 47) If you would like to name a successor attorney-in-fact for 
        // health care decisions, in case your first choice is unable to serve,
        // please list them below: (not required)
        public string SuccessorHealthCareAIF { get; set; }

        public bool CheckedIn { get; set; }

        public enum TimeForService
        {
            Morning = 1,
            Afternoon = 2
        }

    }
	public enum MaritalStatus
	{
		[Display(Name = "Single (divorced)")] SingleAndDivorced = 1,
		[Display(Name = "Single (never divorced)")] SingleAndNeverDivorced = 2,
		[Display(Name = "Presently married, and had a prior marriage " +
			"(previous spouse is deceased or legally divorced)")] SecondMarriage = 3,
		[Display(Name = "Married and my spouse is alive. No previous marriage.")] FirstMarriage = 4,
		[Display(Name = "Widowed")] Widowed = 5
	}

    public enum WhoToInheritEstate
    {
        [Display(Name = "My Spouse")] Spouse = 1,
        [Display(Name = "My then living children, in equal shares")] SplitWithChildren = 2,
        [Display(Name = "My then living children, but if one or more of my children is" +
            " deceased when I die, then his/her share unto that deceased child's" +
            " children (my grandchildren)")] ComplicatedChildren = 3,
        [Display(Name = "A specific person(s) / other")] OtherPerson = 4
    }
}
