using System;
using System.Collections.Generic;
using System.Text;
using WeatherComponent.Contracts;
using WeatherComponent.Models;

namespace WeatherComponent.Service
{
    public class WeatherService : IWeatherService
    {
        public CurrentWeather GetCurrentWeather(string location)
        {

            //Imagine this is a service
            CurrentWeather weather = new CurrentWeather { Location = location, 
                                                            Temperature = 24, 
                                                            WeatherCondition = WeatherCondition.Cloudy 
                                                        };
            return weather;
        }
    }
}
