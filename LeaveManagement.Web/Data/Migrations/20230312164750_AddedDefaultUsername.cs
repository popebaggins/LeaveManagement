using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16615b04-1f69-14e7-1885-121344348bd7",
                column: "ConcurrencyStamp",
                value: "3b7a9382-706d-4499-986a-fa590837d778");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26615b04-1f69-24e7-2885-221344348bd7",
                column: "ConcurrencyStamp",
                value: "1403c974-8abb-4dce-b2df-de4b19b09a68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06615b04-0f69-04e7-0885-021344348bd7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ee53fdad-3ffb-4beb-b78e-9d99ab48602a", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPkOml4ZlC5gR0sFYuBWt39FxsezWVLYIhKsWK/DtTa2mX9RJA53HB6r4oen4ydZmg==", "ac986a92-69bd-49af-8868-d027df96e863", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16615b04-1f69-14e7-1885-121344348bd7",
                column: "ConcurrencyStamp",
                value: "7c715fcf-ea4d-4e2b-980a-4b9d4c4db523");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26615b04-1f69-24e7-2885-221344348bd7",
                column: "ConcurrencyStamp",
                value: "159a4704-6e19-4fbf-8b7d-e234d5762381");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06615b04-0f69-04e7-0885-021344348bd7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc183c9a-9467-42fa-861c-f2ccf2422fb2", false, null, "AQAAAAEAACcQAAAAEBSJS15fSb02lD/MmDJH1niIJas2ytQbGM9ZoBPVR6v+XdYcpDiRc9UMMKYYxqi85w==", "e7b209ad-aa27-4336-a0c0-0ca946e8abaf", null });
        }
    }
}
