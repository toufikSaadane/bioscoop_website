using System;
using Microsoft.EntityFrameworkCore;
using website.Data;

namespace website.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
