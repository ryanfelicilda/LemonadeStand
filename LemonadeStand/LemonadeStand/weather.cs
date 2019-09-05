using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        Random random;
        public int tempHigh;

        public int maxTemp = 100;
        public int minTemp = 32;

        static List<string> conditions;

        private void ConditionsList()
        {
            conditions.Add("Clear Skies");
            conditions.Add("Partly Cloudy");
            conditions.Add("Mostly Cloudy");
            conditions.Add("Cloudy With Rainshowers");
            conditions.Add("Thunderstorm");
        }

        public Weather(Random random)
        {
            this.random = random;
            conditions = new List<string>();
            tempHigh = random.Next(minTemp, maxTemp);
            if(conditions.Count == 0)
            {
                ConditionsList();
            }
            DetermineWeather();
        }

        public void DetermineWeather()
        {

        }
    }
}
