using System;
using Newtonsoft.Json;

namespace Umovie.Model
{
    public class Movie
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("popularity")]
        public string Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("adult")]
        public bool IsAdult { get; set; }

        [JsonProperty("overview")]
        public string OverView { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        public Movie()
        {
        }
    }
}
