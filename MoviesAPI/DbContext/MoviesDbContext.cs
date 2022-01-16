using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesAPI.Domain;

namespace MoviesAPI.DBContext
{
    public class MoviesDbContext:DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserMovieRating>().HasKey(table => new
            {
                table.UserId,
                table.MovieId
            });
            builder.Entity<Movie>().HasData(
             new { MovieId = 1, Title = "Promising Young Woman", YearOfRelease = 2021, RunningTime = 120, AverageRating = 3.668, NumberRated = 5 },
             new { MovieId = 2, Title = "A Quiet Place Part II", YearOfRelease = 2000, RunningTime = 120, AverageRating = 4.66, NumberRated = 10 },
             new { MovieId = 3, Title = "Tenet", YearOfRelease = 2021, RunningTime = 120, AverageRating = 3.66, NumberRated = 25 },
             new { MovieId = 4, Title = "Another Round", YearOfRelease = 2021, RunningTime = 120, AverageRating = 3.99, NumberRated = 15 },
             new { MovieId = 5, Title = "Toy Story", YearOfRelease = 2021, RunningTime = 120, AverageRating = 4.98, NumberRated = 52 },
             new { MovieId = 6, Title = "Late Spring", YearOfRelease = 2021, RunningTime = 120, AverageRating = 4.66, NumberRated = 54 },
             new { MovieId = 7, Title = "Tokyo Story", YearOfRelease = 1945, RunningTime = 120, AverageRating = 3.16, NumberRated = 55 },
             new { MovieId = 8, Title = "Mad Money", YearOfRelease = 2020, RunningTime = 120, AverageRating = 2.23, NumberRated = 65 },
             new { MovieId = 9, Title = "Bad Dreams", YearOfRelease = 2021, RunningTime = 120, AverageRating = 1.45, NumberRated = 75 },
             new { MovieId = 10, Title = "Dreams", YearOfRelease = 2021, RunningTime = 120, AverageRating = 2.66, NumberRated = 85 }
            );
            builder.Entity<MovieGenre>().HasData(
             new { MovieGenreId = 1, GenreType = "Crime", MovieId = 1 },
             new { MovieGenreId = 2, GenreType = "Comedy", MovieId = 1 },
             new { MovieGenreId = 3, GenreType = "Comedy", MovieId = 2 },
             new { MovieGenreId = 4, GenreType = "Drama", MovieId = 2 },
             new { MovieGenreId = 5, GenreType = "Drama", MovieId = 3 },
             new { MovieGenreId = 6, GenreType = "Crime", MovieId = 4 },
             new { MovieGenreId = 7, GenreType = "Sci-Fi", MovieId = 4 },
             new { MovieGenreId = 8, GenreType = "Thriller", MovieId = 5 },
             new { MovieGenreId = 9, GenreType = "Crime", MovieId = 6 },              
             new { MovieGenreId = 10, GenreType = "Crime", MovieId = 8 },
            new { MovieGenreId = 11, GenreType = "Horror", MovieId = 9 },
            new { MovieGenreId = 12, GenreType = "Crime", MovieId = 10 },
            new { MovieGenreId = 13, GenreType = "Comedy", MovieId = 10 },
            new { MovieGenreId = 14, GenreType = "Drama", MovieId = 10 },
            new { MovieGenreId = 15, GenreType = "Horror", MovieId = 7 }
            );
            builder.Entity<User>().HasData(
             new { UserId = 1, Name = "Mathew" },
             new { UserId = 2, Name = "Dan" },
             new { UserId = 3, Name = "Mary " },
             new { UserId = 4, Name = "Tony" },
             new { UserId = 5, Name = "Lisa" },
             new { UserId = 6, Name = "Nicole" },
             new { UserId = 7, Name = "Karen" },
             new { UserId = 8, Name = "Mike" }
             );
            builder.Entity<UserMovieRating>().HasData(
                new { UserId = 1, MovieId = 1, Rating = 4.5},
                new { UserId = 1, MovieId = 2, Rating= 3.0},
                new { UserId = 1, MovieId = 3, Rating = 5.0},
                new { UserId = 1, MovieId = 4, Rating = 3.5 },
                new { UserId = 1, MovieId = 5, Rating = 2.5 },
                new { UserId = 1, MovieId = 6, Rating = 1.5 },
                new { UserId = 2 , MovieId = 1, Rating =4.5 },
                new { UserId = 2, MovieId = 4, Rating = 3.5},
                new { UserId = 3, MovieId = 5, Rating = 5.0 },
                new { UserId = 3, MovieId = 8, Rating = 5.0 },
                new { UserId = 4, MovieId = 6, Rating = 5.0 },
                new { UserId = 5, MovieId = 7, Rating = 5.0 },
                new { UserId = 6, MovieId = 8, Rating = 5.0 },
                new { UserId = 7, MovieId = 9, Rating = 5.0 }
                );
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMovieRating> UserRatings { get; set; }
    }
}

