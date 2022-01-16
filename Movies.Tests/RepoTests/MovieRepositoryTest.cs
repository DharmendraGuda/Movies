using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using MoviesAPI.ApiContracts.Requests;
using MoviesAPI.Business.Interfaces;
using MoviesAPI.Business.Repositories;
using MoviesAPI.DBContext;
using MoviesAPI.Domain;
using MoviesAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Movies.Tests.RepoTests
{
    public class MovieRepositoryTest
    {
        private readonly MoviesDbContext _context;
        private readonly IMovieRepository _movieRepository;
        public  MovieRepositoryTest()
        {
            _context=  DataSeed.GetDatabaseContext().Result;            
            DataSeed.SeedData(_context);           
            _movieRepository = new MovieRepository(_context);
        }
        [Theory]
        [InlineData(null, 1999, null)]
        [InlineData("Promising", null, null)]
        [InlineData(null, null, "Mystery")]
        [InlineData(null, null, "Comedy,Drama")]
        public async void SearchMovies_DataMatch_ReturnList(string title, int? year, string genres )
        {
            var result = await _movieRepository.SearchMovies(new SearchRequest { Title=title, YearofRelease = year, Genres= genres });
            if (year != null) Assert.All(result, r => r.YearOfRelease = year.Value);
            if (title != null) Assert.All(result, r => r.Title.Contains(title));
            if (genres != null) {
                var genrArray = genres.Split(',').ToList();                
                foreach(var movie in result)
                {
                    var genrs = movie.Genres.Any(g => genrArray.Contains(g.GenreType));
                    Assert.True(genrs);
                }
              
            }      
           
        }

        [Theory]
        [InlineData("Promising", null, "dfdffdsfs")]
        [InlineData(null, 2030, "Comedy,Drama")]
        [InlineData("uytuetwuqetwque", 2020, null)]
        public async void SearchMovies_NoMatching_ReturnEmptyList(string title, int? year, string genres)
        {
            var result = await _movieRepository.SearchMovies(new SearchRequest { Title = title, YearofRelease = year, Genres = genres });
            Assert.True(!result.Any());
        }
        [Fact]
        public async void GetTopRatedMovies_ValidData_ReturnMoviesList()
        {           
           
            var actualList = await _movieRepository.GetTopRateddMovies();
            var expectedList = actualList.OrderByDescending(x => x.AverageRating);
            Assert.True(expectedList.SequenceEqual(actualList));
            Assert.Equal(5, actualList.First().AverageRating);
            Assert.True(actualList.Count() <= 5 && actualList.Count() >= 1);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async void GetTopRatedMoviesByUser_Valid_ReturnMovies(int userId)
        {
            var actualList = await _movieRepository.GetTopRatedMoviesByUser(userId);             
            Assert.True(actualList.Count() <=5 && actualList.Count() >=1);
        }

        [Theory]
        [InlineData(9999999)]
        public async void GetTopRatedMoviesByUser_WhenNoRating_ReturnEmptyList(int userId)
        {
            var actualList = await _movieRepository.GetTopRatedMoviesByUser(userId);
            Assert.True(!actualList.Any());
        }
        

    }
}
