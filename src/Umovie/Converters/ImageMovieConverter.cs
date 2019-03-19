using System;
using System.Globalization;
using Umovie.Model.Application;
using Xamarin.Forms;

namespace Umovie.Converters
{
    public class ImageMovieConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "";

            return string.Concat(Constants.Services.BASE_IMAGE_URL, value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
