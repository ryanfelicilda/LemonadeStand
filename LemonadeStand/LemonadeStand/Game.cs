using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Game
    {
        protected abstract int DayCount { get; }

        protected List<Weather> WeatherOnDays = new List<Weather>();

        private Queue<Weather> conditions;

        protected bool PositiveResult = true;

        protected void CreateWeatherForecast()
        {
            Random rnd = new Random();
            // create weather on days
            for (int i = 0; i < DayCount; i++)
            {
                WeatherOnDays.Add(new Weather());
            }
            conditions = new Queue<Weather>(WeatherOnDays);
        }
        // Dependency Inversion Principle: 
        // Reducing dependencies using an interface class creating greater stability.
        protected bool StartNextDay(IDay day)
        {
            if (!conditions.Any()) return false;

            var weatherOnDay = conditions.Dequeue();
            if (PositiveResult)
            {
                day.CheckWeather(weatherOnDay);
                day.BuyIngredients();
                var product = day.CreateProduct();
                if (product == null)
                {
                    PositiveResult = false;
                    return true;
                }
                day.SellProduct(product, weatherOnDay);
            }
            return true;
        }
    }
}
