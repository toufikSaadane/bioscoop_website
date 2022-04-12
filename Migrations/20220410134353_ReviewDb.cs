using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace website.Migrations
{
    public partial class ReviewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Liefde", "Valentijn", 1 },
                    { 2, "Special Vip", "VIP", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

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
        }
    }
}
