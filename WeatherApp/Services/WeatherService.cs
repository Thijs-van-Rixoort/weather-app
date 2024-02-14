using System;
using System.Net.Http.Json;
using weather_app.Models;

namespace weather_app.Services
{
    /// <summary>
    /// A class that is responsible for any weather related data traffic.
    /// </summary>
    internal class WeatherService
    {
        private string _weatherApiKey = Environment.GetEnvironmentVariable("WEATHER_API_KEY")!;
        private HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://api.weatherapi.com/v1/")
        };

        public WeatherService() { }

        /// <summary>
        /// Retrieves the current weather data from an API.
        /// </summary>
        /// <param name="location">The location string that is submitted by the user.</param>
        /// <returns>An object of type WeatherData? wrapped in a task.</returns>
        public async Task<WeatherData?> GetCurrentWeather(string location) {
            WeatherData? returnValue = null;

            try
            {
                returnValue = await this._httpClient.GetFromJsonAsync<WeatherData>($"current.json?key={_weatherApiKey}&q={location}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            
            return returnValue;
        }
    }
}
