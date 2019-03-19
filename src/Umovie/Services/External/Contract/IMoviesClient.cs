using System;
using System.Threading.Tasks;
using Refit;
using Umovie.Model;
using Umovie.Model.Application;

namespace Umovie.Services.External.Contract
{
    
    public interface IMoviesClient
    {
        [Get("/movie/upcoming")]
        Task<MoviesData> GetUpcomingMovies([AliasAs("api_key")] string apiKey, [AliasAs("page")] int page);
    }
}
