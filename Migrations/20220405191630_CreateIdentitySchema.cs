using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace website.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "Id", "Description", "Name", "Price", "SnackId" },
                values: new object[,]
                {
                    { 1, "Liefde", "Valentijn", 50.0, 1 },
                    { 2, "Special Vip", "VIP", 75.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name", "Seats" },
                values: new object[,]
                {
                    { 1, "zaal 1", 180 },
                    { 2, "zaal 2", 180 },
                    { 3, "zaal 3", 180 },
                    { 4, "zaal 4", 180 },
                    { 5, "zaal 5", 180 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Duration", "Genre", "Image", "Language", "MinimalAge", "Name", "PriceAdult", "PriceChild", "PriceSenior", "Score" },
                values: new object[,]
                {
                    { 1, "Voor de allereerste keer in de geschiedenis van de Spider-Man films is onze vriendelijke superheld ontmaskerd en kan hij zijn normale leven niet langer gescheiden houden van zijn gevaarlijke leven als superheld.", 148, null, "https://media.pathe.nl/nocropthumb/180x254/gfx_content/Spider-Man_-No-Way-Home_ps_1_jpg_sd-high_Copyright-MARVEL-2021-CPII-All-Rights-Reserved.jpg", null, 12, "Spider-Man: No Way Home", 0.0, 0.0, 0.0, 0.0 },
                    { 2, "Verborgen geheimen en het gevaar van macht pushen een geheim agent tot het randje in de intense actiethriller Blacklight. Travis Block (Liam Neeson) is freelance ‘fixer’ voor de FBI.", 120, null, "https://media.pathe.nl/nocropthumb/180x254/gfx_content/other/api/filmdepot/v1/movie/download/33695_146276_ps_sd-high.jpg", null, 12, "Blacklight", 0.0, 0.0, 0.0, 0.0 },
                    { 3, "Het is meer dan een oproep… Het is een waarschuwing. Warner Bros. Pictures presenteert The Batman van regisseur Matt Reeves, met in de hoofdrol Robert Pattinson als Gotham City’s bekende misdaadbestrijder en zijn alter ego, de teruggetrokken miljardair Bruce Wayne.", 159, null, "https://media.pathe.nl/nocropthumb/180x254/gfx_content/The-Batman_ps_1_jpg_sd-high_2021-Warner-Bros-Entertainment-Inc-All-Rights-Reserved-Photo-Credit-Courtesy-of-Warner-Bros-Pictures-DC-Comics.jpg", null, 12, "The Batman", 0.0, 0.0, 0.0, 0.0 },
                    { 4, "Weer samen zijn met je beste vrienden, dat is net zo mooi als een perfect uitgevoerde trap in de ballen. De jongens van Jackass keren terug met opnieuw een hele lading hilarische, extreme, absurde en vaak levensgevaarlijke stunts.", 90, null, "https://media.pathe.nl/nocropthumb/180x254/gfx_content/Jackass-Forever_ps_1_jpg_sd-high_Copyright-2021-Paramount-Pictures-All-Rights-Reserved.jpg", null, 12, "Jackass Forever", 0.0, 0.0, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "SeatNumber", "SeatRow" },
                values: new object[,]
                {
                    { 1, 1, "A" },
                    { 2, 2, "B" },
                    { 3, 3, "C" },
                    { 4, 4, "D" },
                    { 5, 5, "E" },
                    { 6, 6, "F" },
                    { 7, 7, "G" },
                    { 8, 8, "H" },
                    { 9, 9, "I" }
                });

            migrationBuilder.InsertData(
                table: "Snacks",
                columns: new[] { "Id", "ArrangementId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, "Zout", "Popcorn", 150.0 },
                    { 2, null, "Vegan", "Nacho", 150.0 }
                });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "Id", "HallId", "MovieId", "startTime" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2022, 4, 5, 21, 51, 29, 626, DateTimeKind.Local).AddTicks(7220) },
                    { 2, 5, 2, new DateTime(2022, 4, 6, 0, 16, 29, 637, DateTimeKind.Local).AddTicks(6320) },
                    { 3, 2, 3, new DateTime(2022, 4, 6, 1, 16, 29, 637, DateTimeKind.Local).AddTicks(6430) },
                    { 4, 3, 4, new DateTime(2022, 4, 5, 22, 16, 29, 637, DateTimeKind.Local).AddTicks(6430) },
                    { 5, 1, 2, new DateTime(2022, 4, 6, 0, 16, 29, 637, DateTimeKind.Local).AddTicks(6430) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Snacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Snacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
