using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.ApiContracts.Requests
{
    public class SearchRequest
    {
        public string Title { set; get; }
        public int? YearofRelease { set; get; }
        public string Genres { set; get; }
    }
}
