using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16615b04-1f69-14e7-1885-121344348bd7",
                column: "ConcurrencyStamp",
                value: "eb8caafa-970c-4f09-a774-5083963e9bbb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26615b04-1f69-24e7-2885-221344348bd7",
                column: "ConcurrencyStamp",
                value: "0b2a9ba0-a7a6-4267-9546-62b4cf5f0ffc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06615b04-0f69-04e7-0885-021344348bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39e5b8d6-da7e-4ce3-9d4b-a875e6a9776f", "AQAAAAEAACcQAAAAENAtcuMKXycVigC4GMYw4hAm68tPWhnDhvwEnocR/BgnoPA9sDp8xEpVCEm1viUuCA==", "7c3c808d-aad5-43e1-b6d8-eb37470d5ae3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16615b04-1f69-14e7-1885-121344348bd7",
                column: "ConcurrencyStamp",
                value: "66cdb738-55e3-47d1-9a45-9b8aeccf5abb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26615b04-1f69-24e7-2885-221344348bd7",
                column: "ConcurrencyStamp",
                value: "f2f7bbe4-3c7b-4267-82d3-9bc328bfc932");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06615b04-0f69-04e7-0885-021344348bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b5a5f02-36da-4089-9cc7-371269f49aea", "AQAAAAEAACcQAAAAEJocmsXxoY+twoW9idOVIiLdhlbJN99d8/gYk5blPlVPM57GzX/yE2wYCflbiR3pRg==", "7ae43f4b-680e-45b8-8a61-7ead2111f8e4" });
        }
    }
}
