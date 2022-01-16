using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Domain
{
    public class UserMovieRating
    {
        [Key, Column(Order = 0)]
        public int UserId{get;set;}

        [Key, Column(Order = 1)] 
        public int MovieId { get; set; }
        [Range(1,5)]        
        public double Rating { get; set; }
        public Movie Movie { get; set; }
    }
}
