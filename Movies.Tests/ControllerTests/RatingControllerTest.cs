using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using MoviesAPI.ApiContracts.Requests;
using MoviesAPI.Business.Interfaces;
using MoviesAPI.Controllers;
using MoviesAPI.Domain;
using MoviesAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Movies.Tests.ControllerTests
{
    public class RatingControllerTest
    {

        private readonly Mock<IRatingRepository> ratingsMock = new Mock<IRatingRepository>();
        private readonly RatingController _ratingController;
        public RatingControllerTest()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperProfile());
            });
            var mapper = mockMapper.CreateMapper();
            _ratingController = new RatingController(ratingsMock.Object, mapper);
        }

        [Fact]
        public async void SaveRating_Vaild_ReturnTrue()
        {
            ratingsMock.Setup(x => x.SaveRating(It.IsAny<UserMovieRating>())).ReturnsAsync(1);
            var result = await _ratingController.SaveRating(new RatingRequest());
            var okResult = Assert.IsType<OkObjectResult>(result);
            //Assert
        }

        [Fact]
        public async void SaveRating_InvalidInput_ReturnNoFound()
        {
            ratingsMock.Setup(x => x.SaveRating(It.IsAny<UserMovieRating>())).ReturnsAsync(0);             
            var result = await _ratingController.SaveRating(new RatingRequest());
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            //Assert
        }

        [Fact]
        public async void SaveRating_InvalidUser_ReturnNotFound()
        {
            ratingsMock.Setup(x => x.SaveRating(It.IsAny<UserMovieRating>())).ReturnsAsync(0);
            var result = await _ratingController.SaveRating(new RatingRequest{ UserId= 9999999, MovieId= 1, Rating=5});
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            
        }

    }
}
