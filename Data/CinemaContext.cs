﻿using System;
using website.Models;
using Microsoft.EntityFrameworkCore;

namespace website.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Performance> Performances { get; set; }
        
        public DbSet<Seats> Seats { get; set; }

        public DbSet<Snack> Snacks { get; set; }

        public DbSet<Arrangement> Arrangements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(FakeData.FakeMovie);
            modelBuilder.Entity<Hall>().HasData(FakeData.FakeHall);
            modelBuilder.Entity<Performance>().HasData(FakeData.FakePerformance);
            modelBuilder.Entity<Snack>().HasData(FakeData.FakeSnack);
            modelBuilder.Entity<Arrangement>().HasData(FakeData.FakeArrangement);
            modelBuilder.Entity<Seats>().HasData(FakeData.FakeSeats);
        }
    }
}
