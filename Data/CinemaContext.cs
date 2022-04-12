using System;
using website.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace website.Data
{
    public class CinemaContext : IdentityDbContext<IdentityUser>
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Performance> Performances { get; set; }

        public DbSet<Seats> Seats { get; set; }

        public DbSet<Snack> Snacks { get; set; }

        public DbSet<Arrangement> Arrangements { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Enquete> Enquetes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(FakeData.FakeMovie);
            modelBuilder.Entity<Hall>().HasData(FakeData.FakeHall);
            modelBuilder.Entity<Performance>().HasData(FakeData.FakePerformance);
            modelBuilder.Entity<Snack>().HasData(FakeData.FakeSnack);
            modelBuilder.Entity<Arrangement>().HasData(FakeData.FakeArrangement);
            modelBuilder.Entity<Seats>().HasData(FakeData.FakeSeats);
            modelBuilder.Entity<Review>().HasData(FakeData.FakeReview);
            modelBuilder.Entity<Enquete>().HasData(FakeData.FakeEnquete);
        }
    }
}
