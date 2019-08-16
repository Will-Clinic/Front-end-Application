using Microsoft.EntityFrameworkCore.Migrations;

namespace WAWillClinicFrontEnd.Migrations.UserDb
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Location",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
