using System;

namespace Umovie.Model.Application
{
    public struct Constants
    {
        public struct Services
        {
            public const string API_KEY = "1f54bd990f1cdfb230adb312546d765d";
            public const string BASE_URL = "https://api.themoviedb.org/3/";
            public const string BASE_IMAGE_URL = "https://image.tmdb.org/t/p/original";
        }

        public struct Pages
        {
            public struct Main
            {
                public const string TITLE = "UMovies - Upcoming List";
            }
        }
    }
}
