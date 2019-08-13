using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WAWillClinicFrontEnd.Migrations.UserDb
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Link = table.Column<string>(nullable: false),
                    ImageURL = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Agree = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IsVeteran = table.Column<bool>(nullable: false),
                    IsWashingtonResident = table.Column<bool>(nullable: false),
                    PreferredTime = table.Column<bool>(nullable: false),
                    ChooseMaritalStatus = table.Column<int>(nullable: false),
                    SpouseName = table.Column<string>(nullable: false),
                    HasChildren = table.Column<bool>(nullable: false),
                    IsCurrentlyPregnant = table.Column<bool>(nullable: false),
                    ChildsParentNotYourSpouse = table.Column<string>(nullable: true),
                    MinorChildName = table.Column<string>(nullable: true),
                    HasSpecialRequest = table.Column<bool>(nullable: true),
                    SpecialRequest = table.Column<string>(nullable: true),
                    PersonToInherit = table.Column<int>(nullable: false),
                    ContRemBeneficiary = table.Column<int>(nullable: false),
                    WantsToDisInherit = table.Column<bool>(nullable: false),
                    DisinheritPerson = table.Column<string>(nullable: true),
                    GuardianName = table.Column<string>(nullable: true),
                    AlternateGuardianName = table.Column<string>(nullable: true),
                    PersonalRep = table.Column<int>(nullable: false),
                    LikesGenPoA = table.Column<bool>(nullable: false),
                    AttorneyInFact = table.Column<string>(nullable: true),
                    SuccessorAttorneyInFact = table.Column<string>(nullable: true),
                    WantHealthCareDirective = table.Column<bool>(nullable: false),
                    Hydration = table.Column<string>(nullable: true),
                    Nutrition = table.Column<string>(nullable: true),
                    CardioAssistance = table.Column<string>(nullable: true),
                    PainMeds = table.Column<string>(nullable: true),
                    LikesPoA = table.Column<bool>(nullable: false),
                    HealthCareAIF = table.Column<string>(nullable: true),
                    SuccessorHealthCareAIF = table.Column<string>(nullable: true),
                    CheckedIn = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
