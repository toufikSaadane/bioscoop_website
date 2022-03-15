using System;
using System.Collections.Generic;
using website.Models;

namespace website.Data
{
    public static class FakeData
    {
        public static List<Movie> FakeMovie
            = new List<Movie> {
                 new Movie
                   {
                       Id = 1,
                       Name = "Spider-Man: No Way Home",
                       Description = "Voor de allereerste keer in de geschiedenis van de Spider-Man films is onze vriendelijke superheld ontmaskerd en kan hij zijn normale leven niet langer gescheiden houden van zijn gevaarlijke leven als superheld.",
                       MinimalAge = 12,
                       Duration = 148,
                       Image = "https://media.pathe.nl/nocropthumb/180x254/gfx_content/Spider-Man_-No-Way-Home_ps_1_jpg_sd-high_Copyright-MARVEL-2021-CPII-All-Rights-Reserved.jpg"
                   },
                    new Movie
                    {
                        Id = 2,
                        Name = "Blacklight",
                        Description = "Verborgen geheimen en het gevaar van macht pushen een geheim agent tot het randje in de intense actiethriller Blacklight. Travis Block (Liam Neeson) is freelance ‘fixer’ voor de FBI.",
                        MinimalAge = 12,
                        Duration = 120,
                        Image = "https://media.pathe.nl/nocropthumb/180x254/gfx_content/other/api/filmdepot/v1/movie/download/33695_146276_ps_sd-high.jpg"
                    },
                    new Movie
                    {
                        Id = 3,
                        Name = "The Batman",
                        Description = "Het is meer dan een oproep… Het is een waarschuwing. Warner Bros. Pictures presenteert The Batman van regisseur Matt Reeves, met in de hoofdrol Robert Pattinson als Gotham City’s bekende misdaadbestrijder en zijn alter ego, de teruggetrokken miljardair Bruce Wayne.",
                        MinimalAge = 12,
                        Duration = 159,
                        Image = "https://media.pathe.nl/nocropthumb/180x254/gfx_content/The-Batman_ps_1_jpg_sd-high_2021-Warner-Bros-Entertainment-Inc-All-Rights-Reserved-Photo-Credit-Courtesy-of-Warner-Bros-Pictures-DC-Comics.jpg"
                    },
                    new Movie
                    {
                        Id = 4,
                        Name = "Jackass Forever",
                        Description = "Weer samen zijn met je beste vrienden, dat is net zo mooi als een perfect uitgevoerde trap in de ballen. De jongens van Jackass keren terug met opnieuw een hele lading hilarische, extreme, absurde en vaak levensgevaarlijke stunts.",
                        MinimalAge = 12,
                        Duration = 90,
                        Image = "https://media.pathe.nl/nocropthumb/180x254/gfx_content/Jackass-Forever_ps_1_jpg_sd-high_Copyright-2021-Paramount-Pictures-All-Rights-Reserved.jpg"
                    }
            };


        public static List<Hall> FakeHall
            = new List<Hall> {
                new Hall
                   {
                       Id = 1,
                       Name = "zaal 1",
                       Seats = 180
                   },
                   new Hall
                   {
                       Id = 2,
                       Name = "zaal 2",
                       Seats = 180
                   },
                   new Hall
                   {
                       Id = 3,
                       Name = "zaal 3",
                       Seats = 180
                   },
                   new Hall
                   {
                       Id = 4,
                       Name = "zaal 4",
                       Seats = 180
                   },
                   new Hall
                   {
                       Id = 5,
                       Name = "zaal 5",
                       Seats = 180
                   }
            };

        public static List<Performance> FakePerformance
            = new List<Performance> {
                new Performance
                   {
                       Id = 1,
                       startTime = DateTime.Now.AddMinutes(35),
                       MovieId = 1,
                       HallId = 2
                   },
                   new Performance
                   {
                       Id = 2,
                       startTime = DateTime.Now.AddHours(3),
                       MovieId = 2,
                       HallId = 5
                   },
                   new Performance
                   {
                       Id = 3,
                       startTime = DateTime.Now.AddHours(4),
                       MovieId = 3,
                       HallId = 2
                   },
                   new Performance
                   {
                       Id = 4,
                       startTime = DateTime.Now.AddHours(1),
                       MovieId = 4,
                       HallId = 3
                   },
                   new Performance
                   {
                       Id = 5,
                       startTime = DateTime.Now.AddHours(3),
                       MovieId = 2,
                       HallId = 1
                   },
            };
    }
}