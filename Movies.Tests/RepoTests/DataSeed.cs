using Microsoft.EntityFrameworkCore;
using MoviesAPI.DBContext;
using MoviesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Tests.RepoTests
{
   public static class DataSeed
    {
        public static async Task<MoviesDbContext>  GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<MoviesDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new MoviesDbContext(options);
            databaseContext.Database.EnsureCreated();

            return databaseContext;
        }

        public static void SeedData(MoviesDbContext databaseContext)
        {
            SeedMovies(databaseContext);
            SeedUsers(databaseContext);
            SeedUserRatings(databaseContext);
        }

        public static async void SeedMovies(MoviesDbContext databaseContext)
        {
            if (await databaseContext.Movies.CountAsync() > 0) {
                return;
            }

                databaseContext.Movies.Add(new Movie {
                MovieId = 1, Title = "Toy Story",
                RunningTime = 100,AverageRating = 3.885,YearOfRelease = 2020,NumberRated = 10,
                Genres= new List<MovieGenre>(){new MovieGenre() { MovieId = 1, GenreType = "Comedy" }, new MovieGenre() { MovieId = 1, GenreType = "Horror" } }
            });            
            databaseContext.Movies.Add(new Movie
            {
                MovieId = 2,Title = "Another Round 2", RunningTime = 120, AverageRating = 4.6, YearOfRelease = 2020,NumberRated = 10,
                Genres = new List<MovieGenre>() { new MovieGenre() { MovieId = 1, GenreType = "Drama" } }
            });            

            databaseContext.Movies.Add(new Movie
            {
                MovieId = 3,
                Title = "Promising Young Woman",
                RunningTime = 120,
                AverageRating = 5,
                YearOfRelease = 1999,
                NumberRated = 10,
                Genres = new List<MovieGenre>() { new MovieGenre() { MovieId = 3, GenreType = "Drama" } }
            });
            databaseContext.Movies.Add(new Movie
            {
                MovieId = 4,
                Title = "Title 4",
                RunningTime = 120,
                AverageRating = 4.6,
                YearOfRelease = 2020,
                NumberRated = 10,
                Genres = new List<MovieGenre>() { new MovieGenre() { MovieId = 4, GenreType = "Mystery" } }
            });

            databaseContext.Movies.Add(new Movie
            {
                MovieId = 5,
                Title = "Title 5",
                RunningTime = 120,
                AverageRating = 4.1111,
                YearOfRelease = 2018,
                NumberRated = 10,
                Genres = new List<MovieGenre>() { new MovieGenre() { MovieId = 5, GenreType = "Drama" } ,new MovieGenre() { MovieId = 1, GenreType = "Thriller" }  }
            });
            databaseContext.Movies.Add(new Movie
            {
                MovieId = 6,
                Title = "Some Title 2",
                RunningTime = 120,
                AverageRating = 3.8999,
                YearOfRelease = 2019,
                NumberRated = 10,
                Genres = new List<MovieGenre>() { new MovieGenre() { MovieId = 6, GenreType = "Drama" } }
            });
            databaseContext.Movies.Add(new Movie
            {
                MovieId = 7,
                Title = "Tokyo Story",
                RunningTime = 120,
                AverageRating = 2,
                YearOfRelease = 2021,
                NumberRated = 10,
                Genres = new List<MovieGenre>() { new MovieGenre() { MovieId = 7, GenreType = "Sci-Fi" } }
            });
            databaseContext.Movies.Add(new Movie
            {
                MovieId = 8,
                Title = "Bad Dreams",
                RunningTime = 120,
                AverageRating = 3,
                YearOfRelease = 2020,
                NumberRated = 10,
                Genres = new List<MovieGenre>() { new MovieGenre() { MovieId = 8, GenreType = "Thriller" } }
            });
            databaseContext.Movies.Add(new Movie
            {
                MovieId = 9,
                Title = "A Quiet Place Part II",
                RunningTime = 120,
                AverageRating = 4.6,
                YearOfRelease = 2010,
                NumberRated = 10,
                Genres = new List<MovieGenre>() { new MovieGenre() { MovieId = 9, GenreType = "Mystery" } }
            });
            await databaseContext.SaveChangesAsync();
            
        }
        public static async void SeedUsers(MoviesDbContext databaseContext)
        {
            if (await databaseContext.Users.CountAsync() > 0)
            {
                return;
            }
            for (int i = 1; i <= 20; i++)
            {
                databaseContext.Users.Add(new User()
                {
                    UserId = i,
                    Name = Guid.NewGuid().ToString()

                }); ;
                await databaseContext.SaveChangesAsync();
            }
        }
        public static async void SeedUserRatings(MoviesDbContext databaseContext)
        {
            if (await databaseContext.UserRatings.CountAsync() > 0)
            {
                return;
            }
            databaseContext.UserRatings.Add(new UserMovieRating { UserId =1, MovieId=1, Rating= 5});
            databaseContext.UserRatings.Add(new UserMovieRating { UserId = 1, MovieId = 2, Rating = 4.2});
            databaseContext.UserRatings.Add(new UserMovieRating { UserId = 1, MovieId = 3, Rating = 3.2 });
            databaseContext.UserRatings.Add(new UserMovieRating { UserId = 1, MovieId = 4, Rating = 3.5 });
            databaseContext.UserRatings.Add(new UserMovieRating { UserId = 1, MovieId = 5, Rating = 3.5 });

            databaseContext.UserRatings.Add(new UserMovieRating { UserId = 2, MovieId = 1, Rating = 5 });
            databaseContext.UserRatings.Add(new UserMovieRating { UserId = 2, MovieId = 3, Rating = 4 });

            databaseContext.UserRatings.Add(new UserMovieRating { UserId = 3, MovieId = 1, Rating = 5 });
            await databaseContext.SaveChangesAsync();
            
        }
    }
}
