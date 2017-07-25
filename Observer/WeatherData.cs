using System;
using System.Collections;
using Observer.Interfaces;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private readonly ArrayList _observers;
        private float _humidity;
        private float _pressure;
        private float _temperature;

        public WeatherData()
        {
            _observers = new ArrayList();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var i = _observers.IndexOf(observer);
            if (i >= 0)
            {
                _observers.Remove(i);
            }
        }

        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                IObserver observer = (IObserver) o;
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();
        }
    }
}