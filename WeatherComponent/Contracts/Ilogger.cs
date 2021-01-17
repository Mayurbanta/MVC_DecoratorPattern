using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherComponent.Contracts
{
    public interface Ilogger
    {
        void LogToFile(string logText);
    }
}
