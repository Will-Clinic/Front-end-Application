﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WAWillClinicFrontEnd.Data;

namespace WAWillClinicFrontEnd.Migrations.UserDb
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20181005050127_add ContRemBeneficiary")]
    partial class addContRemBeneficiary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int>("BackupRep");

                    b.Property<string>("CardioAssistance");

                    b.Property<string>("ChildsParentNotYourSpouse");

                    b.Property<int>("ChooseMaritalStatus");

                    b.Property<int>("ContRemBeneficiary");

                    b.Property<string>("DisinheritPerson");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("GuardianName");

                    b.Property<bool?>("HasChildren");

                    b.Property<bool?>("HasSpecialRequest");

                    b.Property<string>("HealthCareAIF");

                    b.Property<string>("Hydration");

                    b.Property<bool?>("IsCurrentlyPregnant")
                        .IsRequired();

                    b.Property<bool?>("IsVeteran");

                    b.Property<bool?>("IsWashingtonResident")
                        .IsRequired();

                    b.Property<bool?>("LikesGenPoA");

                    b.Property<bool?>("LikesPoA");

                    b.Property<string>("MinorChildName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Nutrition");

                    b.Property<string>("PainMeds");

                    b.Property<int>("PersonToInherit");

                    b.Property<int>("PersonalRep");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("PreferredTime");

                    b.Property<string>("SpecialRequest");

                    b.Property<string>("SpouseName")
                        .IsRequired();

                    b.Property<string>("SuccessorAttorneyInFact");

                    b.Property<string>("SuccessorHealthCareAIF");

                    b.Property<bool?>("WantHealthCareDirective");

                    b.Property<bool?>("WantsToDisInherit");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
