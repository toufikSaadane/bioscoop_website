using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace website.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Snacks_Arrangements_ArrangementId",
                table: "Snacks");

            migrationBuilder.DropIndex(
                name: "IX_Snacks_ArrangementId",
                table: "Snacks");

            migrationBuilder.DropColumn(
                name: "ArrangementId",
                table: "Snacks");

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "startTime",
                value: new DateTime(2022, 4, 5, 22, 53, 56, 990, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 1, 18, 57, 3, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 2, 18, 57, 3, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "startTime",
                value: new DateTime(2022, 4, 5, 23, 18, 57, 3, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "startTime",
                value: new DateTime(2022, 4, 6, 1, 18, 57, 3, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.CreateIndex(
                name: "IX_Arrangements_SnackId",
                table: "Arrangements",
                column: "SnackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arrangements_Snacks_SnackId",
                table: "Arrangements",
                column: "SnackId",
                principalTable: "Snacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arrangements_Snacks_SnackId",
                table: "Arrangements");

            migrationBuilder.DropIndex(
                name: "IX_Arrangements_SnackId",
                table: "Arrangements");

            migrationBuilder.AddColumn<int>(
                name: "ArrangementId",
                table: "Snacks",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Snacks_ArrangementId",
                table: "Snacks",
                column: "ArrangementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Snacks_Arrangements_ArrangementId",
                table: "Snacks",
                column: "ArrangementId",
                principalTable: "Arrangements",
                principalColumn: "Id");
        }
    }
}
