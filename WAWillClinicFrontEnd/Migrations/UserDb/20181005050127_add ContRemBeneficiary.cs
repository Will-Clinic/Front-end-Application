using Microsoft.EntityFrameworkCore.Migrations;

namespace WAWillClinicFrontEnd.Migrations.UserDb
{
    public partial class addContRemBeneficiary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNetWorthLowEnough",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "ContRemBeneficiary",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContRemBeneficiary",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "IsNetWorthLowEnough",
                table: "Users",
                nullable: false,
                defaultValue: false);
        }
    }
}
