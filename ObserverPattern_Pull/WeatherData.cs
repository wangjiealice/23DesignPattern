using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class WeatherData : ISubject
    {
        bool isChanged = false;
        List<IObserver> observers = new List<IObserver>();
        float temp;
        float humidity;
        float pressure;
        public void NotifyObserver(Object arg)
        {
            if(isChanged)
            {
                foreach (IObserver observer in observers)
                {
                    observer.Update(this,null);
                }
            }

            isChanged = false;
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
            SetChanged();
            NotifyObserver(null);
        }

        private void SetChanged()
        {
            isChanged = true;
        }

        public void SetMeasurementData(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementDataChanged();
        }

        public float GetTemperature()
        {
            return temp;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }
    }
}
