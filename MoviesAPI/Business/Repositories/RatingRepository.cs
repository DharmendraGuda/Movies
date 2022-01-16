using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Business.Interfaces;
using MoviesAPI.DBContext;
using MoviesAPI.Domain;
using System.Threading.Tasks;

namespace MoviesAPI.Business.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly MoviesDbContext _dbContext;
        public RatingRepository(MoviesDbContext context)
        {
            _dbContext = context;            
        }

        public async Task<int> SaveRating(UserMovieRating newRating)
        {
            var result = 0;
            if (_dbContext.Movies.AnyAsync(m=>m.MovieId == newRating.MovieId).Result && _dbContext.Users.AnyAsync(m => m.UserId == newRating.UserId).Result)
            {
                var existingRating = await _dbContext.UserRatings.Include(ur => ur.Movie).FirstOrDefaultAsync(ur => ur.UserId == newRating.UserId && ur.MovieId == newRating.MovieId);

                if (existingRating != null)
                {
                    result = await UpdateRating(newRating, existingRating);
                }
                else
                {
                    result = await AddRating(newRating);
                }

            }          
            
            return result;
        }
         private async Task<int> UpdateRating(UserMovieRating newRating, UserMovieRating existingRating)
        {
           var prevRating = existingRating.Rating;         
            existingRating.Rating = newRating.Rating;            
            _dbContext.UserRatings.Update(existingRating);
            var result = await _dbContext.SaveChangesAsync();
            if(result != 0)
            {
                await DetermineAvarageRating(newRating.MovieId, prevRating, newRating.Rating, false);
            }
            return result;
        }
        private async Task<int> AddRating(UserMovieRating newRating)
        {            
            _dbContext.UserRatings.Add(newRating);
            var result = await _dbContext.SaveChangesAsync();
            if (result != -1)
            {
                await DetermineAvarageRating(newRating.MovieId, 0, newRating.Rating, true);
            }
            return result;
        }

       private async Task<int> DetermineAvarageRating(int movieId, double prevUserRating, double currentating, bool incrementUserCnt)
        {
            var movie = await _dbContext.Movies.FirstOrDefaultAsync(m => m.MovieId == movieId);

            var numberRated = movie.NumberRated;
            if (incrementUserCnt) movie.NumberRated = movie.NumberRated + 1;
            movie.AverageRating = ((numberRated * movie.AverageRating) + currentating - prevUserRating) / movie.NumberRated;

            _dbContext.Movies.Update(movie);
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

    }
}
