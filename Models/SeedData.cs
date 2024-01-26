using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data;
using System;
using System.Linq;

namespace WebApplication1.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebApplication1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebApplication1Context>>()))
        {
            //Look for any movies.
            if (context.Movie.Any())
            {
                return;  // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Avatar",
                    ReleaseDate = DateTime.Parse("2009-12-18"),
                    Genre = "Adventure",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The Shape of Water",
                    ReleaseDate = DateTime.Parse("2017-12-1"),
                    Genre = "Adventure",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Genre = "Action",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "La La Land",
                    ReleaseDate = DateTime.Parse("2016-7-16"),
                    Genre = "Comedy",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}
