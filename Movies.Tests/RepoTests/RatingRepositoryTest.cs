using Moq;
using MoviesAPI.Business.Interfaces;
using MoviesAPI.Business.Repositories;
using MoviesAPI.DBContext;
using MoviesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Movies.Tests.RepoTests
{
    public class RatingRepositoryTest
    {
        private readonly MoviesDbContext _context;
        private readonly IRatingRepository _ratingRepository;
        public RatingRepositoryTest()
        {
            _context = DataSeed.GetDatabaseContext().Result;
            DataSeed.SeedData(_context);            
            _ratingRepository = new RatingRepository(_context);
        }

        //[Theory]
        
        [Fact]
        public async void AddRating__ValidInput_shouldAddMovie()
        {           
            var actual = await _ratingRepository.SaveRating(new UserMovieRating {  UserId=4,MovieId=1,Rating=3.5 });
            Assert.Equal(1, actual);
        }
        [Fact]        
       public async void UpdateRating_ValidInput_ShouldUpdateMovie()
        {            
            var actual = await _ratingRepository.SaveRating(new UserMovieRating { UserId = 1, MovieId = 1, Rating = 3.5 });
            Assert.Equal(1, actual);
        }
        [Fact]
        public async void AddRating_InValidInput_ShouldReturn0()
        {
            var actual = await _ratingRepository.SaveRating(new UserMovieRating { UserId = 1, MovieId = 999999, Rating = 3.5 });                      
            Assert.Equal(0, actual);
        }
        

    }
}
