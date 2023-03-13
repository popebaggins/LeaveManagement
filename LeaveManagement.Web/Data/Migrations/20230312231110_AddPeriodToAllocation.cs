using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16615b04-1f69-14e7-1885-121344348bd7",
                column: "ConcurrencyStamp",
                value: "0ddb6599-e0fd-4993-8219-34a20775e6e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26615b04-1f69-24e7-2885-221344348bd7",
                column: "ConcurrencyStamp",
                value: "459fad27-2372-4922-9a90-64ade7efeba1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06615b04-0f69-04e7-0885-021344348bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d5bc73a-7a24-4829-b54b-98103bcda705", "AQAAAAEAACcQAAAAEL88UeEE7/w3Jog2RNP3qj5IzxH5Uuiu4XA7pnZPen0x7bpO5WNL88GKPG7AMx+4bg==", "12333d13-d472-4ae9-ab60-d9d8d277298a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee53fdad-3ffb-4beb-b78e-9d99ab48602a", "AQAAAAEAACcQAAAAEPkOml4ZlC5gR0sFYuBWt39FxsezWVLYIhKsWK/DtTa2mX9RJA53HB6r4oen4ydZmg==", "ac986a92-69bd-49af-8868-d027df96e863" });
        }
    }
}
