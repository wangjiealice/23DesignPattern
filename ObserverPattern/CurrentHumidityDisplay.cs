using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentHumidityDisplay : IObserver, IDisplayElement
    {
        float humidity;
        public void Display()
        {
            Console.WriteLine("Current humidity is {0}", humidity);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.humidity = humidity;
            Display();
        }
    }
}
