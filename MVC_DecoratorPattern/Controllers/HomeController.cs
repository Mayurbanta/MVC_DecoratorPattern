using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeatherComponent.Contracts;

namespace MVC_DecoratorPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            var currentWeather = _weatherService.GetCurrentWeather("Bangalore");
            return View(currentWeather);
        }

        
    }
}
