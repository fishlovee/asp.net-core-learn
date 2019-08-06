using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new RazorPagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<
                RazorPagesMovieContext>>()))
            {
                // look for any movies
                if (context.Movie.Any())
                {
                    return; // db has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Titile = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Rommantic Comedy",
                        Price = 7.99M
                    },
                                        new Movie
                                        {
                                            Titile = "Ghostbusters ",
                                            ReleaseDate = DateTime.Parse("1984-3-13"),
                                            Genre = "Comedy",
                                            Price = 8.99M
                                        },

                    new Movie
                    {
                        Titile = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Titile = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
