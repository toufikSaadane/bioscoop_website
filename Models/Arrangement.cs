using System;
using System.Collections.Generic;

namespace website.Models
{
    public class Arrangement
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Double Price { get; set; }
        public int SnackId { get; set; }

        public Snack Snack { get; set; }
        //public ICollection<Snack> Snacks { get; set; } = new List<Snack>();
    }
}