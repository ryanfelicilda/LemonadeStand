using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public static int MaxTemperature => 100;
        public static int MinTemperature => 32;
        private static Random randomGenerator = new Random();
        public WeatherType Type { get; }
        public int Temperature { get; }
        public Weather()
        {
            Temperature = randomGenerator.Next(MinTemperature, MaxTemperature);
            Type = (WeatherType)randomGenerator.Next(0, 3);
        }
    }
    enum WeatherType
    {
        sunny, cloudy, rainy
    }
}
