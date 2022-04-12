﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using website.Data;

#nullable disable

namespace website.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("website.Models.Enquete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enquetes");
                });

            modelBuilder.Entity("website.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Halls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "zaal 1",
                            Seats = 180
                        },
                        new
                        {
                            Id = 2,
                            Name = "zaal 2",
                            Seats = 180
                        },
                        new
                        {
                            Id = 3,
                            Name = "zaal 3",
                            Seats = 180
                        },
                        new
                        {
                            Id = 4,
                            Name = "zaal 4",
                            Seats = 180
                        },
                        new
                        {
                            Id = 5,
                            Name = "zaal 5",
                            Seats = 180
                        });
                });

            modelBuilder.Entity("website.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Language")
                        .HasColumnType("longtext");

                    b.Property<int>("MinimalAge")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("PriceAdult")
                        .HasColumnType("double");

                    b.Property<double>("PriceChild")
                        .HasColumnType("double");

                    b.Property<double>("PriceSenior")
                        .HasColumnType("double");

                    b.Property<double>("Score")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Voor de allereerste keer in de geschiedenis van de Spider-Man films is onze vriendelijke superheld ontmaskerd en kan hij zijn normale leven niet langer gescheiden houden van zijn gevaarlijke leven als superheld.",
                            Duration = 148,
                            Image = "https://media.pathe.nl/nocropthumb/180x254/gfx_content/Spider-Man_-No-Way-Home_ps_1_jpg_sd-high_Copyright-MARVEL-2021-CPII-All-Rights-Reserved.jpg",
                            MinimalAge = 12,
                            Name = "Spider-Man: No Way Home",
                            PriceAdult = 0.0,
                            PriceChild = 0.0,
                            PriceSenior = 0.0,
                            Score = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Verborgen geheimen en het gevaar van macht pushen een geheim agent tot het randje in de intense actiethriller Blacklight. Travis Block (Liam Neeson) is freelance ‘fixer’ voor de FBI.",
                            Duration = 120,
                            Image = "https://media.pathe.nl/nocropthumb/180x254/gfx_content/other/api/filmdepot/v1/movie/download/33695_146276_ps_sd-high.jpg",
                            MinimalAge = 12,
                            Name = "Blacklight",
                            PriceAdult = 0.0,
                            PriceChild = 0.0,
                            PriceSenior = 0.0,
                            Score = 0.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Het is meer dan een oproep… Het is een waarschuwing. Warner Bros. Pictures presenteert The Batman van regisseur Matt Reeves, met in de hoofdrol Robert Pattinson als Gotham City’s bekende misdaadbestrijder en zijn alter ego, de teruggetrokken miljardair Bruce Wayne.",
                            Duration = 159,
                            Image = "https://media.pathe.nl/nocropthumb/180x254/gfx_content/The-Batman_ps_1_jpg_sd-high_2021-Warner-Bros-Entertainment-Inc-All-Rights-Reserved-Photo-Credit-Courtesy-of-Warner-Bros-Pictures-DC-Comics.jpg",
                            MinimalAge = 12,
                            Name = "The Batman",
                            PriceAdult = 0.0,
                            PriceChild = 0.0,
                            PriceSenior = 0.0,
                            Score = 0.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "Weer samen zijn met je beste vrienden, dat is net zo mooi als een perfect uitgevoerde trap in de ballen. De jongens van Jackass keren terug met opnieuw een hele lading hilarische, extreme, absurde en vaak levensgevaarlijke stunts.",
                            Duration = 90,
                            Image = "https://media.pathe.nl/nocropthumb/180x254/gfx_content/Jackass-Forever_ps_1_jpg_sd-high_Copyright-2021-Paramount-Pictures-All-Rights-Reserved.jpg",
                            MinimalAge = 12,
                            Name = "Jackass Forever",
                            PriceAdult = 0.0,
                            PriceChild = 0.0,
                            PriceSenior = 0.0,
                            Score = 0.0
                        });
                });

            modelBuilder.Entity("website.Models.Performance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.ToTable("Performances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HallId = 2,
                            MovieId = 1,
                            startTime = new DateTime(2022, 4, 12, 0, 45, 15, 461, DateTimeKind.Local).AddTicks(6840)
                        },
                        new
                        {
                            Id = 2,
                            HallId = 5,
                            MovieId = 2,
                            startTime = new DateTime(2022, 4, 12, 3, 10, 15, 494, DateTimeKind.Local).AddTicks(1100)
                        },
                        new
                        {
                            Id = 3,
                            HallId = 2,
                            MovieId = 3,
                            startTime = new DateTime(2022, 4, 12, 4, 10, 15, 494, DateTimeKind.Local).AddTicks(1210)
                        },
                        new
                        {
                            Id = 4,
                            HallId = 3,
                            MovieId = 4,
                            startTime = new DateTime(2022, 4, 12, 1, 10, 15, 494, DateTimeKind.Local).AddTicks(1220)
                        },
                        new
                        {
                            Id = 5,
                            HallId = 1,
                            MovieId = 2,
                            startTime = new DateTime(2022, 4, 12, 3, 10, 15, 494, DateTimeKind.Local).AddTicks(1230)
                        });
                });

            modelBuilder.Entity("website.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("website.Models.Seats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("SeatRow")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SeatNumber = 1,
                            SeatRow = "A"
                        },
                        new
                        {
                            Id = 2,
                            SeatNumber = 2,
                            SeatRow = "B"
                        },
                        new
                        {
                            Id = 3,
                            SeatNumber = 3,
                            SeatRow = "C"
                        },
                        new
                        {
                            Id = 4,
                            SeatNumber = 4,
                            SeatRow = "D"
                        },
                        new
                        {
                            Id = 5,
                            SeatNumber = 5,
                            SeatRow = "E"
                        },
                        new
                        {
                            Id = 6,
                            SeatNumber = 6,
                            SeatRow = "F"
                        },
                        new
                        {
                            Id = 7,
                            SeatNumber = 7,
                            SeatRow = "G"
                        },
                        new
                        {
                            Id = 8,
                            SeatNumber = 8,
                            SeatRow = "H"
                        },
                        new
                        {
                            Id = 9,
                            SeatNumber = 9,
                            SeatRow = "I"
                        });
                });

            modelBuilder.Entity("website.Models.Performance", b =>
                {
                    b.HasOne("website.Models.Hall", "Hall")
                        .WithMany("Perfomances")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("website.Models.Movie", "Movie")
                        .WithMany("Performances")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("website.Models.Hall", b =>
                {
                    b.Navigation("Perfomances");
                });

            modelBuilder.Entity("website.Models.Movie", b =>
                {
                    b.Navigation("Performances");
                });
#pragma warning restore 612, 618
        }
    }
}
