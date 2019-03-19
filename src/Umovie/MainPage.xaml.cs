using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umovie.ViewModels;
using Xamarin.Forms;

namespace Umovie
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ((MainViewModel)this.BindingContext).LoadAsync();
        }
    }
}
