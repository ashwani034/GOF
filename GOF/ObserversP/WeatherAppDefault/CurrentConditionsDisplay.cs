using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.ObserversP.WeatherAppDefault
{
    class CurrentConditionsDisplay : IDisplayElement,IObserver<Weather>
    {
        private float temperature;
        private float humidity;      

        private IDisposable unsubscriber;
        private bool first = true;
        private Weather last;

        public virtual void Subscribe(IObservable<Weather> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Additional temperature data will not be transmitted.");
        }

        public virtual void OnError(Exception error)
        {
            // Do nothing.
        }

        public virtual void OnNext(Weather value)
        {
            temperature = value.Temp;
            humidity = value.Humidity;

            display();
            if (first)
            {
                last = value;
                first = false;
            }
            else
            {
                Console.WriteLine("Change");
            }
        }    

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }     
    }
}
