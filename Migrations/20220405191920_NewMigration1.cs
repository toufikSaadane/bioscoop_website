using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace website.Migrations
{
    public partial class NewMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "startTime",
                value: new DateTime(2022, 4, 5, 21, 54, 19, 386, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 0, 19, 19, 398, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 1, 19, 19, 398, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "startTime",
                value: new DateTime(2022, 4, 5, 22, 19, 19, 398, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 0, 19, 19, 398, DateTimeKind.Local).AddTicks(1170));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "startTime",
                value: new DateTime(2022, 4, 5, 21, 51, 29, 626, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 0, 16, 29, 637, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 1, 16, 29, 637, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "startTime",
                value: new DateTime(2022, 4, 5, 22, 16, 29, 637, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 0, 16, 29, 637, DateTimeKind.Local).AddTicks(6430));
        }
    }
}
