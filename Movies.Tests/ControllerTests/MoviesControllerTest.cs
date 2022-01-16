using System;
using Xunit;
using MoviesAPI;
using System.Threading.Tasks;
using MoviesAPI.DBContext;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Domain;
using MoviesAPI.Business.Interfaces;
using MoviesAPI.Controllers;
using Moq;
using System.Collections.Generic;
using MoviesAPI.ApiContracts.Responses;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MoviesAPI.Helpers;
using MoviesAPI.ApiContracts.Requests;

namespace Movies.Tests
{
    public class MoviesControllerTest
    {
        
        private readonly Mock<IMovieRepository>  moviesMock = new Mock<IMovieRepository>();
        private readonly MoviesController _moviesController;
        public MoviesControllerTest()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperProfile());
            });
            var mapper = mockMapper.CreateMapper();
            _moviesController = new MoviesController(moviesMock.Object, mapper);
        }

        [Fact]
        public async void GetTopRatedMovies_DataExist_ReturnOk()
        {
            moviesMock.Setup(x => x.GetTopRateddMovies()).ReturnsAsync(new List<Movie>() { new Movie { MovieId = 1, NumberRated = 1, AverageRating = 5 } });
            var actual = await _moviesController.TopRateddMovies();
            var  okResult = Assert.IsType<OkObjectResult>(actual.Result);            
        }
        [Fact]
        public async void GetFiltetedRatedMovies_DataExist__ReturnOk()
        {
            moviesMock.Setup(x => x.SearchMovies(It.IsAny<SearchRequest>())).ReturnsAsync(new List<Movie>() { new Movie { MovieId = 1, NumberRated = 1, AverageRating = 5 } });

            var actual = await _moviesController.SearchMovies(new SearchRequest { Title=null, YearofRelease=2020,Genres=null});
            var okResult = Assert.IsType<OkObjectResult>(actual.Result);
        }


        [Fact]
        public async void GetTopRatedMovies_NoData_ReturnNotFound()
        {            
            moviesMock.Setup(x=>x.GetTopRateddMovies()).ReturnsAsync(new List<Movie>());            
            var actual = await _moviesController.TopRateddMovies();
            var notFoundResult = Assert.IsType<NotFoundResult>(actual.Result);
            
        }

        [Fact]
        public async void GetTopRatedMoviesByUser_InvalidUserId_ReturnNotFound()
        {
            moviesMock.Setup(x => x.GetTopRatedMoviesByUser(It.IsAny<int>())).ReturnsAsync(new List<Movie>());            
            var actual = await _moviesController.TopRatedMoviesByUser(99999);               
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(actual.Result);
        }

       
    }
}
