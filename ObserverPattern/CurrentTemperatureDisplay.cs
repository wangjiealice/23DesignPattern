using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentTemperatureDisplay : IObserver, IDisplayElement
    {
        float temperature;
        public void Display()
        {
            Console.WriteLine("Current temperature is {0}", temperature);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            Display();
        }
    }
}
