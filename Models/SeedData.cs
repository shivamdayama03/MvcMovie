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
                    Title = " Avengers ",
                    ReleaseDate = DateTime.Parse("2010-2-12"),
                    Genre = "Action",
                    Price = 2.99M
                },
                new Movie
                {
                    Title = "Avengers-Age of Ultron",
                    ReleaseDate = DateTime.Parse("2012-3-13"),
                    Genre = "Action",
                    Price = 1.99M
                },
                new Movie
                {
                    Title = "12 Strong",
                    ReleaseDate = DateTime.Parse("2016-2-23"),
                    Genre = "War",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "You & me",
                    ReleaseDate = DateTime.Parse("2019-4-15"),
                    Genre = "Romance",
                    Price = 2.99M
                },
                 new Movie
                 {
                     Title = "Greek God",
                     ReleaseDate = DateTime.Parse("2019-03-12"),
                     Genre = "War",
                     Price = 3.99M
                 }
            );
            context.SaveChanges();
        }
    }
}
