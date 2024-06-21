﻿using Microsoft.EntityFrameworkCore;
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
                    Title = "The RM",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Non-Fiction",
                    Rating = "PG",
                    Price = 8.99M
                    
                },
                new Movie
                {
                    Title = "Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "LDS",
                    Rating = "PG",
                    Price = 9.99M
                    
                },
                new Movie
                {
                    Title = "Mount of The Lord",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Non-Fiction",
                    Rating = "PG",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}
