using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using WAWillClinicFrontEnd.Models;

namespace FrontEndTests.ModelTests
{
    public class RSVPUserTests
    {
        [Fact]
        public void RSVPUserIDGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                ID = 1
            };
            Assert.Equal(1, user.ID);
            user.ID = 2;
            Assert.Equal(2, user.ID);
        }
        [Fact]
        public void RSVPUserAgreeGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                Agree = true
            };
            Assert.True(user.Agree);
            user.Agree = false;
            Assert.False(user.Agree
);
        }
        [Fact]
        public void RSVPUserNameGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                Name = "Bob"
            };
            Assert.Equal("Bob", user.Name);
            user.Name = "Steve";
            Assert.Equal("Steve", user.Name);
        }
        [Fact]
        public void RSVPUserAddressGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                Address = "Address1"
            };
            Assert.Equal("Address1", user.Address);
            user.Address = "Address2";
            Assert.Equal("Address2", user.Address);
        }
        [Fact]
        public void RSVPUserPhoneNumberGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                PhoneNumber = "012345"
            };
            Assert.Equal("012345", user.PhoneNumber);
            user.PhoneNumber = "543210";
            Assert.Equal("543210", user.PhoneNumber);
        }
        [Fact]
        public void RSVPUserEmailGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                Email = "fake@email.com"
            };
            Assert.Equal("fake@email.com", user.Email);
            user.Email = "another@fake.com";
            Assert.Equal("another@fake.com", user.Email);
        }
        [Fact]
        public void RSVPUserIsVeteranGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                IsVeteran = true
            };
            Assert.True(user.IsVeteran);
            user.IsVeteran = false;
            Assert.False(user.IsVeteran);
        }
        [Fact]
        public void RSVPUserIsWashingtonResidentGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                IsWashingtonResident = true
            };
            Assert.True(user.IsWashingtonResident);
            user.IsWashingtonResident = false;
            Assert.False(user.IsWashingtonResident);
        }
        [Fact]
        public void RSVPUserPreferredTimeGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                PreferredTime = true
            };
            Assert.True(user.PreferredTime);
            user.PreferredTime = false;
            Assert.False(user.PreferredTime
);
        }
        [Fact]
        public void RSVPUserMaritalStatusGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                ChooseMaritalStatus = MaritalStatus.FirstMarriage
            };
            Assert.Equal(MaritalStatus.FirstMarriage, user.ChooseMaritalStatus);
            user.ChooseMaritalStatus = MaritalStatus.SecondMarriage;
            Assert.Equal(MaritalStatus.SecondMarriage, user.ChooseMaritalStatus);
        }
        [Fact]
        public void RSVPUserSpouseNameGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                SpouseName = "Bob"
            };
            Assert.Equal("Bob", user.SpouseName);
            user.SpouseName = "Steve";
            Assert.Equal("Steve", user.SpouseName);
        }
        [Fact]
        public void RSVPUserHasChildrenGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                HasChildren = true
            };
            Assert.True(user.HasChildren);
            user.HasChildren = false;
            Assert.False(user.HasChildren);
        }
        [Fact]
        public void RSVPUserIsCurrentlyPregnantGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                IsCurrentlyPregnant = true
            };
            Assert.True(user.IsCurrentlyPregnant);
            user.IsCurrentlyPregnant = false;
            Assert.False(user.IsCurrentlyPregnant);
        }
        [Fact]
        public void RSVPUserChildParentNotYourSpouseGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                ChildsParentNotYourSpouse = "Bob"
            };
            Assert.Equal("Bob", user.ChildsParentNotYourSpouse);
            user.ChildsParentNotYourSpouse = "Steve";
            Assert.Equal("Steve", user.ChildsParentNotYourSpouse);
        }
        [Fact]
        public void RSVPUserChildNameGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                MinorChildName = "Bob"
            };
            Assert.Equal("Bob", user.MinorChildName);
            user.MinorChildName = "Steve";
            Assert.Equal("Steve", user.MinorChildName);
        }
        [Fact]
        public void RSVPUserSpecialRequestBoolGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                HasSpecialRequest = true
            };
            Assert.True(user.HasSpecialRequest);
            user.HasSpecialRequest = false;
            Assert.False(user.HasSpecialRequest);
        }
        [Fact]
        public void RSVPUserSpecialRequestStringGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                SpecialRequest = "request1"
            };
            Assert.Equal("request1", user.SpecialRequest);
            user.SpecialRequest = "request2";
            Assert.Equal("request2", user.SpecialRequest);
        }
        [Fact]
        public void RSVPUserPersonToInheritGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                PersonToInherit = WhoToInheritEstate.OtherPerson
            };
            Assert.Equal(WhoToInheritEstate.OtherPerson, user.PersonToInherit);
            user.PersonToInherit = WhoToInheritEstate.ComplicatedChildren;
            Assert.Equal(WhoToInheritEstate.ComplicatedChildren, user.PersonToInherit);
        }
        [Fact]
        public void RSVPUserContRemBeneficiaryGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                ContRemBeneficiary = WhoToInheritEstate.OtherPerson
            };
            Assert.Equal(WhoToInheritEstate.OtherPerson, user.ContRemBeneficiary);
            user.ContRemBeneficiary = WhoToInheritEstate.ComplicatedChildren;
            Assert.Equal(WhoToInheritEstate.ComplicatedChildren, user.ContRemBeneficiary);
        }
        [Fact]
        public void RSVPUserWantsToDisinheritGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                WantsToDisInherit = true
            };
            Assert.True(user.WantsToDisInherit);
            user.WantsToDisInherit = false;
            Assert.False(user.WantsToDisInherit);
        }
        [Fact]
        public void RSVPUserDisinheritPersonGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                DisinheritPerson = "Bob"
            };
            Assert.Equal("Bob", user.DisinheritPerson);
            user.DisinheritPerson = "Steve";
            Assert.Equal("Steve", user.DisinheritPerson);
        }
        [Fact]
        public void RSVPUserGuardianNameGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                GuardianName = "Bob"
            };
            Assert.Equal("Bob", user.GuardianName);
            user.GuardianName = "Steve";
            Assert.Equal("Steve", user.GuardianName);
        }
        [Fact]
        public void RSVPUserAlternativeGuardianGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                AlternateGuardianName = "Bob"
            };
            Assert.Equal("Bob", user.AlternateGuardianName);
            user.AlternateGuardianName = "Steve";
            Assert.Equal("Steve", user.AlternateGuardianName);
        }
        [Fact]
        public void RSVPUserPersonalRepGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                PersonalRep = WhoToInheritEstate.OtherPerson
            };
            Assert.Equal(WhoToInheritEstate.OtherPerson, user.PersonalRep);
            user.PersonalRep = WhoToInheritEstate.ComplicatedChildren;
            Assert.Equal(WhoToInheritEstate.ComplicatedChildren, user.PersonalRep);
        }
        [Fact]
        public void RSVPUserLikesGenGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                LikesGenPoA = true
            };
            Assert.True(user.LikesGenPoA);
            user.LikesGenPoA = false;
            Assert.False(user.LikesGenPoA);
        }
        [Fact]
        public void RSVPUserAttorneyInFactGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                AttorneyInFact = "Bob"
            };
            Assert.Equal("Bob", user.AttorneyInFact);
            user.AttorneyInFact = "Steve";
            Assert.Equal("Steve", user.AttorneyInFact);
        }
        [Fact]
        public void RSVPUserSuccessorAttorneyInFactGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                SuccessorAttorneyInFact = "Bob"
            };
            Assert.Equal("Bob", user.SuccessorAttorneyInFact);
            user.SuccessorAttorneyInFact = "Steve";
            Assert.Equal("Steve", user.SuccessorAttorneyInFact);
        }
        [Fact]
        public void RSVPUserWantsHealthCareDirectiveGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                WantHealthCareDirective = true
            };
            Assert.True(user.WantHealthCareDirective);
            user.WantHealthCareDirective = false;
            Assert.False(user.WantHealthCareDirective);
        }
        [Fact]
        public void RSVPUserHydrationGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                Hydration = "test"
            };
            Assert.Equal("test", user.Hydration);
            user.Hydration = "test2";
            Assert.Equal("test2", user.Hydration);
        }
        [Fact]
        public void RSVPUserNutritionGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                Nutrition = "test"
            };
            Assert.Equal("test", user.Nutrition);
            user.Nutrition = "test2";
            Assert.Equal("test2", user.Nutrition);
        }
        [Fact]
        public void RSVPUserCardioAssistanceGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                CardioAssistance = "test"
            };
            Assert.Equal("test", user.CardioAssistance);
            user.CardioAssistance = "test2";
            Assert.Equal("test2", user.CardioAssistance);
        }
        [Fact]
        public void RSVPUserPainMedsGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                PainMeds = "test"
            };
            Assert.Equal("test", user.PainMeds);
            user.PainMeds = "test2";
            Assert.Equal("test2", user.PainMeds);
        }
        [Fact]
        public void RSVPUserLikesPoAGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                LikesPoA = true
            };
            Assert.True(user.LikesPoA);
            user.LikesPoA = false;
            Assert.False(user.LikesPoA);
        }
        [Fact]
        public void RSVPUserHealthcareAIFGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                HealthCareAIF = "test"
            };
            Assert.Equal("test", user.HealthCareAIF);
            user.HealthCareAIF = "test2";
            Assert.Equal("test2", user.HealthCareAIF);
        }
        [Fact]
        public void RSVPUserSuccessorHealthcareAIFGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                SuccessorHealthCareAIF = "test"
            };
            Assert.Equal("test", user.SuccessorHealthCareAIF);
            user.SuccessorHealthCareAIF = "test2";
            Assert.Equal("test2", user.SuccessorHealthCareAIF);
        }
        [Fact]
        public void RSVPUserCheckedInGetterAndSetter()
        {
            RSVPUser user = new RSVPUser
            {
                CheckedIn = true
            };
            Assert.True(user.CheckedIn);
            user.CheckedIn = false;
            Assert.False(user.CheckedIn);
        }
    }
}
