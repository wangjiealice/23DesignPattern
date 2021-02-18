using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentPressureDisplay : IObserver, IDisplayElement
    {
        float pressure;
        public CurrentPressureDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current pressure is {0}", pressure);
        }

        public void Update(ISubject weatherData, Object obj)
        {
            if (weatherData is WeatherData)
            {
                WeatherData data = weatherData as WeatherData;
                this.pressure = data.GetPressure();
                Display();
            }
        }
    }
}
