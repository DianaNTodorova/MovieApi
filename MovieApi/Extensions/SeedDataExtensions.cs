using Microsoft.EntityFrameworkCore;
using MovieApi.Data;
using MovieApi.Models;

public static class SeedDataExtensions
{
    public static void SeedData(this WebApplication app) //app.SeedData();
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<MovieApiContext>();
        context.Database.Migrate(); 

       
        if (!context.Movie.Any())
        {
            context.Movie.AddRange(
            new Movie { Id = 1, Title = "Titanic", Year = new DateTime(2014, 4, 4), Duration = 2, Genre = "Sci-Fi" },
            new Movie { Id = 2, Title = "Inception", Year = new DateTime(2010, 7, 16), Duration = 2, Genre = "Sci-Fi" });
            context.SaveChanges();
        }
        if (!context.Actor.Any())
        {
            context.Actor.AddRange(
            new Actor { Id = 1, Name = "Leonardo DiCaprio", BirthYear = new DateTime(1969, 5, 5) },
            new Actor { Id = 2, Name = "Leonardo SomeOne", BirthYear = new DateTime(1969, 5, 5) });
            context.SaveChanges();
        }
       
       
        if (!context.MovieDetails.Any())
        {
            context.MovieDetails.AddRange(
            new MovieDetails { MovieId = 1, Synopsis = "Some great movie", Language = "English", Budget = 100000 },
            new MovieDetails { MovieId = 2, Synopsis = "Some great movie", Language = "English", Budget = 900000 });
            context.SaveChanges();
        }
        if (!context.Review.Any())
        {
            context.Review.AddRange(
            new Review { Id = 1, MovieId = 1, Rating = 5, Comment = "Amazing movie!" },
            new Review { Id = 2, MovieId = 2, Rating = 4, Comment = "Great plot!" });
            context.SaveChanges();
        }
    }
}
