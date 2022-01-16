using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Business.Interfaces;
using MoviesAPI.ApiContracts.Requests;
using System.Threading.Tasks;
using AutoMapper;
using MoviesAPI.Domain;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingRepository _ratingRepository;
        private IMapper _mapper;
        public RatingController( IRatingRepository ratingRepository, IMapper mapper)
        {
            _ratingRepository = ratingRepository;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> SaveRating([FromBody] RatingRequest rating)
        {
            var res= await _ratingRepository.SaveRating(_mapper.Map<UserMovieRating>(rating));
            if (res <=0) return NotFound("User or Movie Not Found");
           return Ok(res);
        }
    }
}
