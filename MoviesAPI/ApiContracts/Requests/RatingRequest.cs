using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.ApiContracts.Requests
{
    public class RatingRequest
    {
       // public int UserMovieRatingId { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
       public double Rating { get; set; }
    }
}
