using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public String Name { get; set; }
        public ICollection<UserMovieRating> Ratings { get; set; }
    }
}
