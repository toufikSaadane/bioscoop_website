using System;
using System.Collections.Generic;

namespace website.Models
{
    public class Snack
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public ICollection<Arrangement> Arrangements { get; set; } = new List<Arrangement>();
        //public Arrangement Arrangement { get; set; }
    }
}
