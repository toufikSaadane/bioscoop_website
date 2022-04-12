using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace website.Migrations
{
    public partial class LoginUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 12, 55, 41, 196, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 15, 20, 41, 209, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 16, 20, 41, 209, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 13, 20, 41, 209, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 15, 20, 41, 209, DateTimeKind.Local).AddTicks(6880));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 12, 21, 38, 361, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 14, 46, 38, 372, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 15, 46, 38, 372, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 12, 46, 38, 372, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "startTime",
                value: new DateTime(2022, 4, 11, 14, 46, 38, 372, DateTimeKind.Local).AddTicks(7130));
        }
    }
}
