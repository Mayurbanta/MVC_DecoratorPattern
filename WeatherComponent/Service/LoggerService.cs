using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WeatherComponent.Contracts;

namespace WeatherComponent.Service
{
    public class LoggerService : Ilogger
    {
        public void LogToFile(string logText)
        {
            Debug.WriteLine("WEATHER SERVICE: " + logText);
        }
    }
}
