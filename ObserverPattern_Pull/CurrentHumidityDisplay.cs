using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentHumidityDisplay : IObserver, IDisplayElement
    {
        float humidity;
        public CurrentHumidityDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current humidity is {0}", humidity);
        }

        public void Update(ISubject weatherData, Object obj)
        {
            if(weatherData is WeatherData)
            {
                WeatherData data = weatherData as WeatherData;
                this.humidity = data.GetHumidity();
                Display();
            }
        }
    }
}
