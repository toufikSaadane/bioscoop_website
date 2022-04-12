using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace website.Migrations
{
    public partial class WorkName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkName",
                table: "Movies",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 17, 8, 17, 379, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 19, 33, 17, 390, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 20, 33, 17, 390, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 17, 33, 17, 390, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 19, 33, 17, 390, DateTimeKind.Local).AddTicks(4110));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkName",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 16, 18, 52, 931, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 18, 43, 52, 942, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 19, 43, 52, 942, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 16, 43, 52, 942, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "startTime",
                value: new DateTime(2022, 4, 10, 18, 43, 52, 942, DateTimeKind.Local).AddTicks(5580));
        }
    }
}
