﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentWeatherDisplay : IObserver, IDisplayElement
    {
        float temp;
        float humidity;
        float pressure;
        public void Display()
        {
            Console.WriteLine("Current temp is {0}, humidity is {1}, pressure is {2}.", temp, humidity, pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
