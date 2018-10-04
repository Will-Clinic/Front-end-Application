using Microsoft.EntityFrameworkCore.Migrations;

namespace WAWillClinicFrontEnd.Migrations.UserDb
{
    public partial class addedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Agree",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AlternateGuardianName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AttorneyInFact",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BackupRep",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CardioAssistance",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChildsParentNotYourSpouse",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChooseMaritalStatus",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContRemBeneficiary",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisinheritPerson",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuardianName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasChildren",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasProofOfService",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasSpecialRequest",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthCareAIF",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hydration",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentlyPregnant",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNetWorthLowEnough",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVeteran",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsWashingtonResident",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LikesGenPoA",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LikesPoA",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinorChildName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nutrition",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PainMeds",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonToInherit",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalRep",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SpecialRequest",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpouseName",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SuccessorAttorneyInFact",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuccessorHealthCareAIF",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WantHealthCareDirective",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WantsToDisInherit",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Agree",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AlternateGuardianName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AttorneyInFact",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BackupRep",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CardioAssistance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ChildsParentNotYourSpouse",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ChooseMaritalStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ContRemBeneficiary",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DisinheritPerson",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GuardianName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HasChildren",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HasProofOfService",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HasSpecialRequest",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HealthCareAIF",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Hydration",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsCurrentlyPregnant",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsNetWorthLowEnough",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsVeteran",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsWashingtonResident",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LikesGenPoA",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LikesPoA",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MinorChildName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Nutrition",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PainMeds",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonToInherit",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonalRep",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SpecialRequest",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SpouseName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SuccessorAttorneyInFact",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SuccessorHealthCareAIF",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WantHealthCareDirective",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WantsToDisInherit",
                table: "Users");
        }
    }
}
