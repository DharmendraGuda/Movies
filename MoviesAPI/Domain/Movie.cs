using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Domain
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
        public int RunningTime { get; set; }      
        public int NumberRated { get; set; }
        public double AverageRating { get; set; }
        public ICollection<MovieGenre> Genres { get; set; }

    }
}
