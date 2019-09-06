using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public double cup;
        public double cupCost;
        public double ice;
        public double iceCost;
        public double sugar;
        public double sugarCost;
        public double lemon;
        public double lemonCost;
        public double itemAmount;

        public Store()
        {
            cup = .10;
            ice = .05;
            sugar = .25;
            lemon = .35;
        }
        public string ChooseItem(Player player)
        {

            Console.WriteLine("What would you like to buy?\n" + "Cup, Ice, Sugar, or Lemon\n" + "Enter: Back to go back.\n");
            string playerChoice = Console.ReadLine().ToLower();
            switch (playerChoice)
            {
                case "Cup":
                    Console.WriteLine($"Balance: ${player.money}");
                    break;
                case "Ice":
                    Console.WriteLine($"Balance: ${player.money}");
                    break;
                case "Sugar":
                    Console.WriteLine($"Balance: ${player.money}");
                    break;
                case "Lemon":
                    Console.WriteLine($"Balance: ${player.money}");
                    break;
            }
            return playerChoice;
        }

        public double CupAmount()
        {
            Console.WriteLine("How many cups would you like to buy?");
            itemAmount = int.Parse(Console.ReadLine());
            double cupCost = cup * itemAmount;
            return cupCost;
        }
        public double IceAmount()
        {
            Console.WriteLine("How many ice would you like to buy?");
            itemAmount = int.Parse(Console.ReadLine());
            double iceCost = ice * itemAmount;
            return iceCost;
        }
        public double SugarAmount()
        {
            Console.WriteLine("How many sugar would you like to buy?");
            itemAmount = int.Parse(Console.ReadLine());
            double sugarCost = sugar * itemAmount;
            return sugarCost;
        }
        public double LemonAmount()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            itemAmount = int.Parse(Console.ReadLine());
            double lemonCost = lemon * itemAmount;
            return lemonCost;
        }
    }
}
