using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        private static double money = 30;
        public static double Lemon { get; private set; }
        public static double Sugar { get; private set; }
        public static double Ice { get; private set; }
        public static double MinuteMaid { get; private set; }
        public static double Balance
        {
            get => Math.Round(money, 2);
            private set
            {
                money = value;
            }
        }
        public static void AddToBalance(double amount)
        {
            Balance += amount;
        }
        public static void BuyLemon(double lemonCount)
        {
            Lemon += lemonCount;
            Balance -= lemonCount * Store.LemonPrice;
        }
        public static void GetLemon(double lemonCount)
        {
            Lemon -= lemonCount;
        }
        public static bool CanGetLemon(double lemonCount)
        {
            return Lemon >= lemonCount;
        }
    }
}
