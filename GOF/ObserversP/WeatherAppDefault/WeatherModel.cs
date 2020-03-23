using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.ObserversP.WeatherAppDefault
{
    public class Weather
    {
        private float _temp;
        private float _humidity;
        private float _pressure;

        public Weather(float temp, float humidity, float pressure)
        {
            this._temp = temp;
            this._humidity = humidity;
            this._pressure = pressure;
        }

        public float Temp  { get { return this._temp; } }
        public float Humidity { get { return this._humidity; } }
        public float Pressure { get { return this._pressure; } }       
    }
    public interface IDisplayElement
    {
        public void display();
    }
}
