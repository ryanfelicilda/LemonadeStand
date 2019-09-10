using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class RunGame : Game
    {
        protected override int DayCount => 7;

        public RunGame()
        {
            Console.WriteLine("INSTRUCTIONS:\n\n" +
            "Your goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.\n" +
            "Buy store bought lemonade, lemons, sugar packets, and ice cubes, then set your recipe based on the weather conditions.\n" +
            "Start by selling store bought lemonade (basic recipe), but try to vary the recipe and see if ou can do better.\n" +
            "Lastly, set your prices and sell your lemonade at the stand.\n" +
            "Try changing up the price based on the weather conditions as well.\n" +
            "At the end of the game, you'll see how much money you made.\n" +
            "Write it down and play again to try and beat your score!\n\n");
            Console.WriteLine("Weather Forecast");
            CreateWeatherForecast();
            for (int i = 0; i < WeatherOnDays.Count; i++)
            {
                Console.WriteLine($"Day {i + 1} : {WeatherOnDays[i].Type.ToString()}, temperature is {WeatherOnDays[i].Temperature}F");
            }
            Console.WriteLine("\n");

            RunDay runDay = new RunDay();
            while (StartNextDay(runDay))
            {
                Console.Clear();
                runDay = new RunDay();
            }

            Console.Clear();
            if (PositiveResult)
            {
                Console.WriteLine($"You've been at it for {WeatherOnDays.Count} days.");
                Console.WriteLine($"Money balance: {Inventory.Balance}");
            }
            else
            {
                Console.WriteLine("Looks like you don't have anything left to sell. Better luck next time.");
            }
            Console.ReadLine();
        }
    }
}
