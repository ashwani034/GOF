using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GOF.ObserversP.WeatherAppDefault
{
    internal static class ClsWeatherData
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData() {  };

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            
            weatherData.SendNotification(new Weather(80, 75, 29.2f));
            weatherData.SendNotification(new Weather(82, 70, 29.2f));

            currentDisplay.Subscribe(weatherData);
            weatherData.SendNotification(new Weather(78, 90, 29.2f));

            Console.ReadLine();
        }
    }
    public class WeatherData : IObservable<Weather>
    {
        private List<IObserver<Weather>> observers;    

        public WeatherData()
        {
            observers = new List<IObserver<Weather>>();
        }            

        public IDisposable Subscribe(IObserver<Weather> observer)
        {            
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Weather>> _observers;
            private IObserver<Weather> _observer;

            public Unsubscriber(List<IObserver<Weather>> observers, IObserver<Weather> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null)) _observers.Remove(_observer);
            }
        }

        public void SendNotification(Weather obj)
        {
            foreach (var observer in observers)
            {
                if (obj == null)
                {
                    observer.OnError(new MessageUnknownException("null ref error"));
                }
                else
                {
                    observer.OnNext(obj);
                }
            }
        }
    }

    public class MessageUnknownException : Exception
    {
        private string _Messages;
        public MessageUnknownException(string message) : base(message)
        {
            _Messages = message;
        }

        public MessageUnknownException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public override string Message => _Messages;

        public MessageUnknownException()
        {
        }
    }
}
