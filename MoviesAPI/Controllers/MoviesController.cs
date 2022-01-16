using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Business.Interfaces;
using MoviesAPI.ApiContracts.Requests;
using MoviesAPI.ApiContracts.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]   
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        private IMapper _mapper;
        public MoviesController(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        [HttpGet("SearchMovies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MovieResponse>>> SearchMovies([FromQuery]SearchRequest request)
        {
            var movies = await _movieRepository.SearchMovies(request);
            if (movies.Any())
                return Ok(_mapper.Map<List<MovieResponse>>(movies));
            else 
                return NotFound();

        }

        [HttpGet("TopRatedMoviesByUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MovieResponse>>> TopRatedMoviesByUser(int userId)
        {
            if (userId == 0) return BadRequest("Invalid User");
            var movies = await _movieRepository.GetTopRatedMoviesByUser(userId);
            if (movies.Any())
                return Ok(_mapper.Map<List<MovieResponse>>(movies));
            else
                return NotFound("No Movie Results");

        }

        [HttpGet("TopRateddMovies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MovieResponse>>> TopRateddMovies()
        {
            var movies = await _movieRepository.GetTopRateddMovies();
            if (movies.Any())
                return Ok(_mapper.Map<List<MovieResponse>>(movies));
            else
                return NotFound();

        }


    }
}
