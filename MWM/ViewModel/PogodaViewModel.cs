using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_IO.MWM.ViewModel
{
    class PogodaViewModel
    {
        //kolekcja do wyświetlania danych w ItemsControl
        public ObservableCollection<WeatherHour> WeatherByHour { get; set; }

        public PogodaViewModel()
        {
            //przykładowe dane
            WeatherByHour = new ObservableCollection<WeatherHour>
            {
                new WeatherHour { Hour = "14:00", IconPath = "/weathericons/clouds.png", Temperature = "0°C", Precipitation = "2%" },
                new WeatherHour { Hour = "15:00", IconPath = "/weathericons/sun.png", Temperature = "1°C", Precipitation = "1%" },
                new WeatherHour { Hour = "16:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "17:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "18:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "19:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "20:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "21:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "22:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "23:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "00:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "01:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "02:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "03:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "04:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "05:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "06:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
                new WeatherHour { Hour = "07:00", IconPath = "/weathericons/rain.png", Temperature = "2°C", Precipitation = "5%" },
            };
        }
    }

    //klasa modelu danych dla pogody na godzinę
    public class WeatherHour
    {
        public string Hour { get; set; }
        public string IconPath { get; set; }
        public string Temperature { get; set; }
        public string Precipitation { get; set; }
    }
}


