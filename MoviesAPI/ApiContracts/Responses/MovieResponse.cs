using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.ApiContracts.Responses
{
    public class MovieResponse
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
        public int RunningTime { get; set; }
        public string Genres { get; set; }
        public double AverageRating { get; set; }
    }
}
