using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentPressureDisplay currentPressureDisplay = new CurrentPressureDisplay();
            CurrentHumidityDisplay currentHumidityDisplay = new CurrentHumidityDisplay();
            CurrentTemperatureDisplay currentTemperatureDisplay = new CurrentTemperatureDisplay();
            CurrentWeatherDisplay currentWeatherDisplay = new CurrentWeatherDisplay();

            weatherData.RegisterObserver(currentPressureDisplay);
            weatherData.RegisterObserver(currentHumidityDisplay);
            weatherData.RegisterObserver(currentTemperatureDisplay);
            weatherData.RegisterObserver(currentWeatherDisplay);

            weatherData.SetMeasurementData(1,2,3);

            weatherData.RemoveObserver(currentHumidityDisplay);
            weatherData.RemoveObserver(currentTemperatureDisplay);

            weatherData.SetMeasurementData(6, 6, 6);
        }
    }
}
