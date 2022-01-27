using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Contracts.V1
{    
    public static class ApiRoutes
    {
        public const string Version = "api";
        public const string Root = "v1";
        public const string Base  =  Root+ "/" + Version;
        public static class Movies
        {
            public const string SearchMovies = Base+ "/SearchMovies";
            public const string TopRatedMoviesByUser = Base + "/TopRatedMoviesByUser";
            public const string TopRatedMovies = Base + "/TopRatedMovies";
        }

        public static class Ratings
        {
            public const string SaveRating = Base + "/SaveRating";
            
        }
    }
}
