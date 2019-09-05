using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int tempHigh;
        List<string> conditions;

        public Weather()
        {
            conditions = new List<string>();
            conditions.Add("Clear Skies");
            conditions.Add("Partly Cloudy");
            conditions.Add("Mostly Cloudy");
            conditions.Add("Cloudy With Rainshowers");
            conditions.Add("Thunderstorm");
        }
        public int SetTemp()
        {
            int maxTemp = 100;
            int minTemp = 32;
            Random rnd = new Random();
            tempHigh = rnd.Next(minTemp, maxTemp);
            return tempHigh;
        }
        public string SetCondition()
        {
            Random rnd = new Random();
            int i = rnd.Next(conditions.Count);
            string wxCondition = conditions[i];
            return wxCondition;
        }
    }
}
