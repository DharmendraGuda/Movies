using MoviesAPI.ApiContracts.Requests;
using MoviesAPI.ApiContracts.Responses;
using MoviesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Business.Interfaces
{
    public interface IRatingRepository
    {
        Task<int> SaveRating(UserMovieRating UserRating);
    }
}
