using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentPressureDisplay : IObserver, IDisplayElement
    {
        float pressure;
        public void Display()
        {
            Console.WriteLine("Current pressure is {0}", pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.pressure = pressure;
            Display();
        }
    }
}
