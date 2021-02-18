using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentTemperatureDisplay : IObserver, IDisplayElement
    {
        float temperature;
        public CurrentTemperatureDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current temperature is {0}", temperature);
        }

        public void Update(ISubject weatherData, Object obj)
        {
            if (weatherData is WeatherData)
            {
                WeatherData data = weatherData as WeatherData;
                this.temperature = data.GetTemperature();
                Display();
            }
        }
    }
}
