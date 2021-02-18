using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
