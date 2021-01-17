using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherComponent.Models
{
    public enum WeatherCondition
    {
        Sunny,
        Rain,
        Cloudy
    }

    public class CurrentWeather
    {
        public string Location { get; set; }
        public double Temperature { get; set; }
        public WeatherCondition WeatherCondition { get; set; }
    }
}
