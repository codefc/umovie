using System;
using System.Threading.Tasks;
using Umovie.Model;

namespace Umovie.Services.Contract
{
    public interface IMovieService
    {
        Task<MoviesData> GetUpcomingMovies(int page);
    }
}
