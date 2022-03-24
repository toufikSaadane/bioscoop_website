using System;
namespace website.Models
{
    public class Performance
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public DateTime startTime { get; set; }

        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
    }
}
