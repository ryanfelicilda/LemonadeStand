using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class RunDay : IDay
    {
        private double dayLoss = 0;
        public void CheckWeather(Weather weather)
        {
            Console.WriteLine("Welcome to Ryan's Lemonade Stand. Let's sell some lemonade!");
            Console.WriteLine($"Today is {weather.Type} with a temperature of {weather.Temperature}F");
            Console.WriteLine("Let's go to the store and buy some ingredients.");
        }
        public void BuyIngredients()
        {
            Console.WriteLine($"You have ${Inventory.Balance}");
            Console.WriteLine("Choose an item to buy from the store.");
            Console.WriteLine($"1. Store bought lemonade. Price: ${BasicRecipe.GetCost()}");
            Console.WriteLine($"2. Lemon. Price: ${Store.LemonPrice}");
            Console.WriteLine($"3. Sugar Packets. Price: ${Store.SugarPrice}");
            Console.WriteLine($"4. Ice Cubes. Price: ${Store.IcePrice}");
            Console.WriteLine($"5. Done shopping.");

            while (true)
            {
                Console.WriteLine("What would you like to buy? ");
                int userInput = Validation.ReadUserInput(5);
                switch (userInput)
                {
                    case 1:
                        {
                            BuyItem((count) => { Inventory.BuyBasicRecipe(count); dayLoss -= count * BasicRecipe.GetCost(); }, BasicRecipe.GetCost());
                            break;
                        }
                    case 2:
                        {
                            BuyItem((count) => { Inventory.BuyLemon(count); dayLoss -= count * Store.LemonPrice; }, Store.LemonPrice);
                            break;
                        }
                    case 3:
                        {
                            BuyItem((count) => { Inventory.BuySugar(count); dayLoss -= count * Store.SugarPrice; }, Store.SugarPrice);
                            break;
                        }
                    case 4:
                        {
                            BuyItem((count) => { Inventory.BuyIce(count); dayLoss -= count * Store.IcePrice; }, Store.IcePrice);
                            break;
                        }
                    case 5:
                        {
                            return;
                        }
                }
            }
        }
        private void BuyItem(Action<double> buyAction, double price)
        {
            Console.WriteLine("How many would you like to buy?");
            double amount = Validation.ReadDoubleLine();

            if (Inventory.CanBuy(amount * price))
            {
                buyAction.Invoke(amount);
                Console.WriteLine($"You have ${Inventory.Balance} left.");
            }
            else
            {
                Console.WriteLine("Sorry, you're broke as a joke.");
            }
        }
        public BasicRecipe CreateProduct()
        {
            Console.WriteLine($"Inventory:");
            Console.WriteLine($"Store bought lemonade = {Inventory.BasicRecipe}");
            Console.WriteLine($"Lemons = {Inventory.Lemon}");
            Console.WriteLine($"Sugar Packets = {Inventory.Sugar}");
            Console.WriteLine($"Ice Cubes = {Inventory.Ice}");

            if (Inventory.BasicRecipe == 0 &&
                Inventory.Lemon == 0 &&
                Inventory.Sugar == 0 &&
                Inventory.Ice == 0 &&
                Inventory.Balance <= Store.IcePrice)
            {

                return null;
            }


            while (true)
            {
                Console.WriteLine("What would you like to sell today?");
                Console.WriteLine("1. Store bought lemonade");
                Console.WriteLine("2. Homemade lemonade");

                switch (Validation.ReadUserInput(2))
                {
                    case 1:
                        {
                            Console.WriteLine("How many store bought lemonade do you want to sell?");
                            var amount = Validation.ReadDoubleLine();
                            if (Inventory.GetBasicRecipe(amount))
                            {
                                return new BasicRecipe(amount);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough.");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("How many lemons would you like to use?");
                            var lemonAmount = Validation.ReadDoubleLine();
                            if (!Inventory.CanGetLemon(lemonAmount))
                            {
                                Console.WriteLine("You don't have enough.");
                                break;
                            }
                            Console.WriteLine("How many sugar packets would you like to use?");
                            var sugarAmount = Validation.ReadDoubleLine();
                            if (!Inventory.CanGetSugar(sugarAmount))
                            {
                                Console.WriteLine("You don't have enough.");
                                break;
                            }
                            Console.WriteLine("How many ice cubes would you like to use?");
                            var iceAmount = Validation.ReadDoubleLine();
                            if (!Inventory.CanGetIce(iceAmount))
                            {
                                Console.WriteLine("You don't have enough.");
                                break;
                            }

                            Inventory.GetIce(iceAmount);
                            Inventory.GetSugar(sugarAmount);
                            Inventory.GetLemon(lemonAmount);

                            return new CustomRecipe(lemonAmount, sugarAmount, iceAmount);
                        }
                }
            }
        }
        public void SellProduct(BasicRecipe product, Weather weather)
        {
            Console.WriteLine($"Today will be {weather.Type} with a temperature of {weather.Temperature}F");
            Console.WriteLine("How much would you like to sell your lemonade for today?");
            double price = Validation.ReadDoubleLine();

            Console.Clear();
            Console.WriteLine("Selling lemonade...");
            Console.ReadLine();
            Console.Clear();

            double dayProfit = 0;
            for (int i = 0; i < CustomerCountLogic.CustomerLogic(weather); i++)
            {
                Customer customer = new Customer();
                if (customer.GonnaBuy(price))
                {
                    dayProfit += price + product.setting;
                    Inventory.AddToBalance(price + product.setting);
                }
            }

            Console.Clear();
            Console.WriteLine($"Today, you spent ${Math.Round(dayLoss, 2)} at the store for ingredients, " +
                $"and made ${Math.Round(dayProfit, 2)}. Profit/Loss for today: ${Math.Round(dayProfit + dayLoss, 2)}");
            Console.WriteLine("What a long day. Take a break and try again tomorrow. Press Enter to get some sleep.");
            Console.ReadLine();
            Console.WriteLine("Nap time...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
