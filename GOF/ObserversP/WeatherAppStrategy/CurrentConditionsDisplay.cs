using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.ObserversP.WeatherAppStrategy
{
    class CurrentConditionsDisplay : IDisplayElement, IWeatherObserver
    {
        private float temperature;
        private float humidity;
        private ISubject<IWeatherObserver> weatherData;

        public CurrentConditionsDisplay(ISubject<IWeatherObserver> weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}
