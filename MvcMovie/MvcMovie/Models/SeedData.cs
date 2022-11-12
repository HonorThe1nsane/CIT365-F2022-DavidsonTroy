using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-01-31"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = .50M
                },
                new Movie
                {
                    Title = "Saints and Soldiers ",
                    ReleaseDate = DateTime.Parse("2003-09-11"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 0.78M
                },
                new Movie
                {
                    Title = "Mobsters and Mormons",
                    ReleaseDate = DateTime.Parse("2005-09-09"),
                    Genre = "Comedy",
                     Rating = "PG",
                    Price = .35M
                },
                new Movie
                {
                    Title = "Charly",
                    ReleaseDate = DateTime.Parse("2002-09-20"),
                    Genre = "Romance",
                    Rating = "PG",
                    Price = 2.22M
                }
            );
            context.SaveChanges();
        }
    }
}