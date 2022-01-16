using MoviesAPI.ApiContracts.Requests;
using MoviesAPI.ApiContracts.Responses;
using MoviesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Business.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> SearchMovies(SearchRequest searchParams);
        Task<IEnumerable<Movie>> GetTopRateddMovies();
        Task<IEnumerable<Movie>> GetTopRatedMoviesByUser(int userId);
        
    }
}
