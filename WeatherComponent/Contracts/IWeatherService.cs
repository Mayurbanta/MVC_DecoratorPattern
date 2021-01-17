using System;
using System.Collections.Generic;
using System.Text;
using WeatherComponent.Models;

namespace WeatherComponent.Contracts
{
    public interface IWeatherService
    {
        CurrentWeather GetCurrentWeather(String location);
        //LocationForecast GetForecast(String location);
    }
}
