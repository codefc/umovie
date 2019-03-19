using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MVVMCoffee.Models;
using MVVMCoffee.ViewModels;
using Umovie.Model;
using Umovie.Model.Application;
using Umovie.Services.Contract;
using Xamarin.Forms;
using Xamarin.Forms.Extended;

namespace Umovie.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public InfiniteScrollCollection<Movie> Movies { get; private set; }
        private readonly IMovieService _service;

        private int _totalPages;
        private int _currentPage;


        public MainViewModel()
        {
            Movies = new InfiniteScrollCollection<Movie>() 
            { 
                OnLoadMore = async() => {
                    return await LoadMovies();
                    }
            };

            TitlePage = Constants.Pages.Main.TITLE;
            _currentPage = 1;
            _totalPages = 1;
            _service = DependencyService.Get<IMovieService>();
        }

        public override async Task LoadAsync()
        {
            Movies.AddRange(await LoadMovies());
        }

        private async Task<List<Movie>> LoadMovies()
        {
            List<Movie> movies = new List<Movie>();
            try
            {
                Ocupado = true;

                var result = await _service.GetUpcomingMovies(_currentPage);

                _currentPage = result.GetNextPage();
                _totalPages = result.TotalPages;

                movies =  result.Results;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Ocupado = false;
            }

            return movies;
        }
    }
}
