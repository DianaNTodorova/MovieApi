using Microsoft.EntityFrameworkCore;
using MovieApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Data
{
    public class MovieApiContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; } = default!;
        public DbSet<MovieDetails> MovieDetails { get; set; } = default!;
        public DbSet<Review> Review { get; set; } = default!;
        public DbSet<MovieApi.Models.Movie> Movie { get; set; } = default!;

        public MovieApiContext(DbContextOptions<MovieApiContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // Configure the many-to-many relationship between Movie and Actor
            modelBuilder.Entity<MovieActor>()
                .HasKey(ma => new { ma.MovieId, ma.ActorId });
            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Movie)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(ma => ma.MovieId);
            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Actor)
                .WithMany(a => a.MovieActors)
                .HasForeignKey(ma => ma.ActorId);
            // Configure the one-to-one relationship between Movie and MovieDetails
            modelBuilder.Entity<Movie>()
                .HasOne(m => m.MovieDetails)
                .WithOne(md => md.Movie)
                .HasForeignKey<MovieDetails>(md => md.MovieId);
            // Configure the one-to-many relationship between Movie and Review
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Reviews)
                .WithOne(r => r.Movie)
                .HasForeignKey(r => r.MovieId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MovieApi;Trusted_Connection=True;ConnectRetryCount=0");
            }

        }
    }
}
