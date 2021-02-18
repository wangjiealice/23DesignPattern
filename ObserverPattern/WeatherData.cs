using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class WeatherData : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        float temp;
        float humidity;
        float pressure;
        public void NotifyObserver()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(temp, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void MeasurementDataChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurementData(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementDataChanged();
        }
    }
}
