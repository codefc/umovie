using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Umovie.Model
{
    public class MoviesData
    {
        public List<Movie> Results { get; protected set; }

        [JsonProperty("page")]
        public int Page { get; protected set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; protected set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; protected set; }

        public int GetNextPage()
        {
            return (Page < TotalPages) ? ++Page : TotalPages;
        }

        public MoviesData()
        {
            Results = new List<Movie>();
        }
    }
}
