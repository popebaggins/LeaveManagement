using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
