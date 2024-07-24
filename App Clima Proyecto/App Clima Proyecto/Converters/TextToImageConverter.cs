using System;
using System.Globalization;
using Xamarin.Forms;

namespace App_Clima_Proyecto.Converters
{
    class TextToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string weather = value as string;
            string path = string.Empty;
            switch (weather)
            {
                case "clear-day":
                    path = "clearDay";
                    break;
                case "clear-night":
                    path = "clearNight";
                    break;
                case "rain":
                    path = "rain";
                    break;
                case "snow":
                    path = "snow";
                    break;
                case "sleet":
                    path = "sleet";
                    break;
                case "wind":
                    path = "wind";
                    break;
                case "fog":
                    path = "fog";
                    break;
                case "cloudy":
                    path = "cloudy";
                    break;
                case "partly-cloudy-day":
                    path = "partlyCloudyDay";
                    break;
                case "partly-cloudy-night":
                    path = "partlyCloudyNight";
                    break;
                    // Prefiero omitir el default

            }
            return path;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
