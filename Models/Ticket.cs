using System;
using System.Collections.Generic;

namespace website.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Performance_id { get; set; }
        public int Hall_id { get; set; }

        public Performance Performance { get; set; }
        public Hall Hall { get; set; }
        public ICollection<Performance> Performances { get; set; } = new List<Performance>();

    }
}
