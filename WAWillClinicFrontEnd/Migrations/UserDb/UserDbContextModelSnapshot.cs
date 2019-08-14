﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WAWillClinicFrontEnd.Data;

namespace WAWillClinicFrontEnd.Migrations.UserDb
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WAWillClinicFrontEnd.Models.Resource", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("ImageURL")
                        .IsRequired();

                    b.Property<string>("Link")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("Resources");

                    b.HasData(
                        new { ID = 1, Description = "", ImageURL = "", Link = "https://www.va.gov/health-care/", Title = "VA HealthCare", Type = 5 },
                        new { ID = 2, Description = "", ImageURL = "", Link = "https://www.militaryonesource.mil/", Title = "OneSource", Type = 3 },
                        new { ID = 3, Description = "", ImageURL = "", Link = "https://www.benefits.va.gov/benefits/services.asp", Title = "VA Services", Type = 4 }
                    );
                });

            modelBuilder.Entity("WAWillClinicFrontEnd.Models.RSVPUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<bool?>("Agree")
                        .IsRequired();

                    b.Property<string>("AlternateGuardianName");

                    b.Property<string>("AttorneyInFact");

                    b.Property<string>("CardioAssistance");

                    b.Property<bool>("CheckedIn");

                    b.Property<string>("ChildsParentNotYourSpouse");

                    b.Property<int>("ChooseMaritalStatus");

                    b.Property<int>("ContRemBeneficiary");

                    b.Property<string>("DisinheritPerson");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("GuardianName");

                    b.Property<bool>("HasChildren");

                    b.Property<bool?>("HasSpecialRequest");

                    b.Property<string>("HealthCareAIF");

                    b.Property<string>("Hydration");

                    b.Property<bool>("IsCurrentlyPregnant");

                    b.Property<bool>("IsVeteran");

                    b.Property<bool>("IsWashingtonResident");

                    b.Property<bool>("LikesGenPoA");

                    b.Property<bool>("LikesPoA");

                    b.Property<int>("Location");

                    b.Property<string>("MinorChildName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Nutrition");

                    b.Property<string>("PainMeds");

                    b.Property<int>("PersonToInherit");

                    b.Property<int>("PersonalRep");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<bool>("PreferredTime");

                    b.Property<string>("SpecialRequest");

                    b.Property<string>("SpouseName")
                        .IsRequired();

                    b.Property<string>("SuccessorAttorneyInFact");

                    b.Property<string>("SuccessorHealthCareAIF");

                    b.Property<bool>("WantHealthCareDirective");

                    b.Property<bool>("WantsToDisInherit");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WAWillClinicFrontEnd.Models.Volunteer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalComments");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("Pairing");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int>("Profession");

                    b.Property<int>("VolunteerCity");

                    b.Property<bool>("VolunteerTimeAfternoon");

                    b.Property<bool>("VolunteerTimeMorning");

                    b.HasKey("ID");

                    b.ToTable("Volunteers");
                });
#pragma warning restore 612, 618
        }
    }
}
