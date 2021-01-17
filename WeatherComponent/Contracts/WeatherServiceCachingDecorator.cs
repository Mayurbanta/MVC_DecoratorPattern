using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherComponent.Models;

namespace WeatherComponent.Contracts
{
    public class WeatherServiceCachingDecorator : IWeatherService
    {

        private readonly IWeatherService _innerWeatherService;
        private readonly IMemoryCache _cache;
        public WeatherServiceCachingDecorator(IWeatherService innerWeatherService, IMemoryCache cache)
        {
            _innerWeatherService = innerWeatherService;
            _cache = cache;
        }

        public CurrentWeather GetCurrentWeather(string location)
        {
            string cacheKey = $"WeatherCondition::{location}";
            if (_cache.TryGetValue<CurrentWeather>(cacheKey, out var currentWeather))
            {
                return currentWeather;
            }
            else
            {
                var currentConditions = _innerWeatherService.GetCurrentWeather(location);
                _cache.Set<CurrentWeather>(cacheKey, currentConditions, TimeSpan.FromMinutes(30));
                return currentConditions;
            }
        }
    }
}
