using Microsoft.EntityFrameworkCore.Migrations;

namespace WAWillClinicFrontEnd.Migrations
{
    public partial class AddedCheckedIn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CheckedIn",
                table: "Users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckedIn",
                table: "Users");
        }
    }
}
