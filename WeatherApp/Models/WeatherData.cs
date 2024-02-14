using System.Text.Json.Serialization;

namespace weather_app.Models
{
    /// <summary>
    /// A model that is used to structure the data that is retrieved from the weather api.
    /// </summary>
    internal class WeatherData
    {
        public Location Location { get; set; }
        public CurrentWeatherData Current { get; set; }
    }

    internal class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        [JsonPropertyName("tz_id")]
        public string TimezoneId { get; set; }
        public string Localtime {  get; set; }
    }

    internal class CurrentWeatherData
    {
        [JsonPropertyName("temp_c")]
        public decimal TemperatureInCelsius { get; set; }
        public WeatherCondition Condition { get; set; }
        [JsonPropertyName("wind_kph")]
        public decimal WindspeedInKph { get; set; }
        [JsonPropertyName("wind_dir")]
        public string WindDirection { get; set; }
        [JsonPropertyName("precip_mm")]
        public decimal PrecipitationInMilimeters { get; set; }
        public int Humidity { get; set; }
        [JsonPropertyName("feelslike_c")]
        public decimal FeelslikeInCelsius { get; set; }
        public decimal Uv { get; set; }
        [JsonPropertyName("gust_kph")]
        public decimal WindGustsInKph { get; set; }
    }

    internal class WeatherCondition
    {
        public string Text { get; set; }
    }
}