using weather_app.Models;
using weather_app.Services;

namespace weather_app
{
    /// <summary>
    /// A class that contains all the functionality for a simple weather data form.
    /// </summary>
    public partial class WeatherForm : Form
    {
        private WeatherService _weatherService = new();

        public WeatherForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieves the current weather data from a weather API.
        /// </summary>
        /// <param name="sender">The button that this event handler is bound to.</param>
        /// <param name="e">The event data.</param>
        private async void GetWeatherButton_Click(object sender, EventArgs e)
        {
            WeatherData? weatherData = await _weatherService.GetCurrentWeather(LocationTextBox.Text);

            if (weatherData != null)
            {
                UpdateWeatherDataLabels(weatherData);
            } else
            {
                SetErrorLabel();
            }
        }

        /// <summary>
        /// Updates the weather data labels and resets the error label.
        /// </summary>
        /// <param name="weatherData">A parameter of type WeatherData containing all the weather data that is received from the weather API.</param>
        private void UpdateWeatherDataLabels(WeatherData weatherData)
        {
            this.CurrentLocationLabel.Text = $"{weatherData.Location.Name}, {weatherData.Location.Region}, {weatherData.Location.Country}";
            this.CurrentTimeLabel.Text = $"{weatherData.Location.Localtime} ({weatherData.Location.TimezoneId})";
            this.CurrentConditionLabel.Text = $"{weatherData.Current.Condition.Text}";
            this.CurrentTemperatureLabel.Text = $"{weatherData.Current.TemperatureInCelsius} °C, feels like  {weatherData.Current.FeelslikeInCelsius}°C";
            this.CurrentWindLabel.Text = $"{weatherData.Current.WindspeedInKph}km/h, {weatherData.Current.WindDirection} (gusts of wind up to {weatherData.Current.WindGustsInKph}km/h)";
            this.CurrentPrecipitationLabel.Text = $"{weatherData.Current.PrecipitationInMilimeters}mm";
            this.CurrentHumidityLabel.Text = $"{weatherData.Current.Humidity}%";
            this.CurrentUvIndexLabel.Text = $"{weatherData.Current.Uv}";
            CurrentErrorLabel.Text = "";
        }

        /// <summary>
        /// Updates the error label to display a generic error.
        /// </summary>
        private void SetErrorLabel()
        {
            this.CurrentErrorLabel.Text = "this location is invalid!";
        }
    }
}
