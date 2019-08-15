using Microsoft.EntityFrameworkCore.Migrations;

namespace WAWillClinicFrontEnd.Migrations.UserDb
{
    public partial class dataadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pairing",
                table: "Volunteers");

            migrationBuilder.AddColumn<bool>(
                name: "MemberPair",
                table: "Volunteers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MentorPair",
                table: "Volunteers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Nopair",
                table: "Volunteers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberPair",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "MentorPair",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "Nopair",
                table: "Volunteers");

            migrationBuilder.AddColumn<int>(
                name: "Pairing",
                table: "Volunteers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
