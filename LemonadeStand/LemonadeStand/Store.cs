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
        public double ice;
        public double sugar;
        public double lemon;

        public Store()
        {
            cup = .10;
            ice = .05;
            sugar = .25;
            lemon = .35;
        }
        public string ChooseItem()
        {

            Console.WriteLine("What would you like to buy?\n" + "Cup, Ice, Sugar, or Lemon\n" + "Enter: Back to go back.\n");
            string playerChoice = Console.ReadLine().ToLower();
            switch (playerChoice)
            {
                case "Cup":
                    Console.WriteLine($"Balance: ${Player.money}");
                    break;
                case "Ice":
                    Console.WriteLine($"Balance: ${Player.money}");
                    break;
                case "Sugar":
                    Console.WriteLine($"Balance: ${Player.money}");
                    break;
                case "Lemon":
                    Console.WriteLine($"Balance: ${Player.money}");
                    break;
                case "Back":
                    UserInterface();
                    break;

            }
            return playerChoice;
        }

        public double CupAmount()
        {
            Console.WriteLine("How many cups would you like to buy?");
            int itemAmount = int.Parse(Console.ReadLine());
            double totalCost = cup * itemAmount;
            return totalCost;
            
        }
        public double IceAmount()
        {
            Console.WriteLine("How many ice would you like to buy?");
            int itemAmount = int.Parse(Console.ReadLine());
            double totalCost = ice * itemAmount;
            return totalCost;

        }
        public double SugarAmount()
        {
            Console.WriteLine("How many sugar would you like to buy?");
            int itemAmount = int.Parse(Console.ReadLine());
            double totalCost = sugar * itemAmount;
            return totalCost;

        }
        public double LemonAmount()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int itemAmount = int.Parse(Console.ReadLine());
            double totalCost = lemon * itemAmount;
            return totalCost;

        }
    }
}
