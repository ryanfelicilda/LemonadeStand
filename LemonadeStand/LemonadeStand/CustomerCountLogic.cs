using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CustomerCountLogic
    {
        public static int CustomerLogic(Weather weather)
        {
            int currentCount = 0;
            switch (weather.Type)
            {
                case WeatherType.sunny: currentCount = 25; break;
                case WeatherType.cloudy: currentCount = 20; break;
                case WeatherType.rainy: currentCount = 15; break;
                default: return 0;
            }

            double factor = (double)weather.Temperature / (double)Weather.MaxTemperature;
            currentCount = (int)(currentCount * factor);

            return currentCount;
        }
    }
}
