using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Domain
{
    public class MovieGenre
    {
        public int MovieGenreId { set; get; }
        public int MovieId { set; get; }
        public string GenreType { set; get; }
    }
}
