using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MoviesAPI.ApiContracts.Requests;
using MoviesAPI.ApiContracts.Responses;
using MoviesAPI.Domain;

namespace MoviesAPI.Helpers
{
    public class MapperProfile : Profile
    {
        public  MapperProfile()
        {
            
                CreateMap<RatingRequest, UserMovieRating>();
                CreateMap<UserMovieRating, RatingRequest>();

                CreateMap<Movie, MovieResponse>()
                .ForMember(rs =>rs.AverageRating, rq=>rq.MapFrom(rq=> Math.Round(rq.AverageRating * 2, MidpointRounding.AwayFromZero) / 2))
                .ForMember(rs=> rs.Genres, rq=>rq.MapFrom(rq => string.Join(',' , rq.Genres.Select(x=>x.GenreType).ToList())));
                

           
        }
    }
}
