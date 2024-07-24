using App_Clima_Proyecto.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_Clima_Proyecto.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private WeatherData _data;

        public WeatherData Data { get => _data; set { _data = value; OnPropertyChanged(); } }
        public ICommand SearchCommand { get; set; }

        public MainPageViewModel()
        {
            SearchCommand = new Command(async (terminoDeBusqueda) =>
            {
                await GetData($"https://api.pirateweather.net/forecast/gy76djUSd0xEiowqvbo0nmbat7TirOuu/{terminoDeBusqueda}");
            }
            );
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public async Task GetData(string url)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var response =
            await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();

            // Logging para ver la impresion en consola
            System.Diagnostics.Debug.WriteLine(jsonResult);


            var result = JsonConvert.DeserializeObject<WeatherData>(jsonResult);
            Data = result;
        }
    }
}
