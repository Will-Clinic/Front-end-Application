using Microsoft.EntityFrameworkCore.Migrations;

namespace WAWillClinicFrontEnd.Migrations.ApplicationDb
{
    public partial class NewClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "fd4a5b5f-c287-4d60-8671-1d9bc923aee1", "e08c48d4-2788-4071-97ec-6105b2e90179" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f4fac013-47c9-49e9-b00f-0ec15a3dbf26", 0, "a19602d9-7713-4a0f-ac62-a2e31e0568a7", "admin@admin.com", false, "Admin", "Test", false, null, null, null, null, null, false, null, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f4fac013-47c9-49e9-b00f-0ec15a3dbf26", "a19602d9-7713-4a0f-ac62-a2e31e0568a7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd4a5b5f-c287-4d60-8671-1d9bc923aee1", 0, "e08c48d4-2788-4071-97ec-6105b2e90179", "admin@admin.com", false, "Admin", "Test", false, null, null, null, null, null, false, null, false, null });
        }
    }
}
