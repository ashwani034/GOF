using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.ObserversP.WeatherAppStrategy
{
    interface ISubject<T>
    {
        public void registerObserver(T o);
        public void removeObserver(T o);
        public void notifyObservers();

    }

    public interface IWeatherObserver
    {
        public void update(float temp, float humidity, float pressure);
    }
    public interface IDisplayElement
    {
        public void display();
    }
}
