using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentPressureDisplay currentPressureDisplay = new CurrentPressureDisplay(weatherData);
            CurrentHumidityDisplay currentHumidityDisplay = new CurrentHumidityDisplay(weatherData);
            CurrentTemperatureDisplay currentTemperatureDisplay = new CurrentTemperatureDisplay(weatherData);
            CurrentWeatherDisplay currentWeatherDisplay = new CurrentWeatherDisplay(weatherData);
           
            weatherData.SetMeasurementData(1,2,3);

            weatherData.RemoveObserver(currentHumidityDisplay);
            weatherData.RemoveObserver(currentTemperatureDisplay);

            weatherData.SetMeasurementData(6, 6, 6);
        }
    }
}
