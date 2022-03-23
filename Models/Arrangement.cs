using System;
namespace website.Models
{
    public class Arrangement
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int SnackId { get; set; }

        public Snack Snack { get; set; }
    }
}
