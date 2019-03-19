using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Refit;
using Umovie.Model;
using Umovie.Model.Application;
using Umovie.Services;
using Umovie.Services.Contract;
using Umovie.Services.External.Contract;

[assembly:Xamarin.Forms.Dependency(typeof(MovieService))]
namespace Umovie.Services
{
   
    public class MovieService : IMovieService
    {
        private IMoviesClient _client;

        public MovieService()
        {
            _client = RestService.For<IMoviesClient>(Constants.Services.BASE_URL);
        }

        public async Task<MoviesData> GetUpcomingMovies(int page)
        {
            return await _client.GetUpcomingMovies(Constants.Services.API_KEY, page);
        }
    }
}
