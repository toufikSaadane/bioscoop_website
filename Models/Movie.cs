using System;
using System.Collections.Generic;

namespace website.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinimalAge { get; set; }
        public int Duration { get; set; }
        public string Image { get; set; }
        public double PriceChild { get; set; }
        public double PriceAdult { get; set; }
        public double PriceSenior { get; set; }

        public ICollection<Performance> Performances { get; set; } = new List<Performance>();
    }
}
