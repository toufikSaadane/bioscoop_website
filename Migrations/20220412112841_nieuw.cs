using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace website.Migrations
{
    public partial class nieuw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Seats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MinimalAge = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Score = table.Column<double>(type: "double", nullable: false),
                    Genre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Language = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PriceChild = table.Column<double>(type: "double", nullable: false),
                    PriceAdult = table.Column<double>(type: "double", nullable: false),
                    PriceSenior = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeatRow = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeatNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    HallId = table.Column<int>(type: "int", nullable: false),
                    startTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                table: "Performances",
                columns: new[] { "Id", "HallId", "MovieId", "startTime" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2022, 4, 12, 14, 3, 41, 592, DateTimeKind.Local).AddTicks(8080) },
                    { 2, 5, 2, new DateTime(2022, 4, 12, 16, 28, 41, 626, DateTimeKind.Local).AddTicks(3120) },
                    { 3, 2, 3, new DateTime(2022, 4, 12, 17, 28, 41, 626, DateTimeKind.Local).AddTicks(3230) },
                    { 4, 3, 4, new DateTime(2022, 4, 12, 14, 28, 41, 626, DateTimeKind.Local).AddTicks(3240) },
                    { 5, 1, 2, new DateTime(2022, 4, 12, 16, 28, 41, 626, DateTimeKind.Local).AddTicks(3250) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Performances_HallId",
                table: "Performances",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_MovieId",
                table: "Performances",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
