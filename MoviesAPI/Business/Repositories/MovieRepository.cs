using MoviesAPI.ApiContracts.Requests;
using MoviesAPI.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesAPI.DBContext;
using AutoMapper;
using MoviesAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace MoviesAPI.Business.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesDbContext _dbContext;        
        public MovieRepository(MoviesDbContext context )
        {
            _dbContext = context;            
        }
        public async Task<IEnumerable<Movie>> SearchMovies(SearchRequest request)
        {
            IEnumerable<string> genres;
            genres=  !string.IsNullOrWhiteSpace(request.Genres) ?request.Genres.Split(',').ToList(): new List<string>();

            var movies = await _dbContext.Movies.Include(m => m.Genres)
                .Where  (m => (String.IsNullOrEmpty(request.Title) || m.Title.Contains(request.Title))
                            && ( request.YearofRelease == null || m.YearOfRelease == request.YearofRelease.Value)
                            &&( String.IsNullOrEmpty(request.Genres) || m.Genres.Any(g => genres.Contains(g.GenreType)))
                        )
                .OrderBy(m => m.Title)
                .ToListAsync();           

            return movies;
        }

        public async Task<IEnumerable<Movie>> GetTopRateddMovies()
        {
            var movies = await _dbContext.Movies.Include(m => m.Genres).OrderByDescending(m=>m.AverageRating).ThenBy(m => m.Title).Take(5).ToListAsync();
            return movies;
        }

        public async Task<IEnumerable<Movie>> GetTopRatedMoviesByUser(int userId)
        {
                var movies = await _dbContext.UserRatings.Where(ur => ur.UserId == userId)
                    .OrderByDescending(m => m.Rating).Take(5).Include(ur => ur.Movie).Select(ur => ur.Movie).OrderBy(m => m.Title).ToListAsync();
                return movies;            
            
        }
    }
}
