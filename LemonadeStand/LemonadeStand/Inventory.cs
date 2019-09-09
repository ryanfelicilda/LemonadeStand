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
        public static double BasicRecipe { get; private set; }
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
        public static void BuySugar(double sugarCount)
        {
            Sugar += sugarCount;
            Balance -= sugarCount * Store.SugarPrice;
        }
        public static void GetSugar(double sugarCount)
        {
            Sugar -= sugarCount;
        }
        public static bool CanGetSugar(double sugarCount)
        {
            return Sugar >= sugarCount;
        }
        public static void BuyIce(double iceCount)
        {
            Ice += iceCount;
            Balance -= iceCount * Store.IcePrice;
        }
        public static void GetIce(double iceCount)
        {
            Ice -= iceCount;
        }
        public static bool CanGetIce(double iceCount)
        {
            return Ice >= iceCount;
        }
        public static void BuyBasicRecipe(double recipeCount)
        {
            BasicRecipe += recipeCount;
            Balance -= recipeCount * LemonadeStand.BasicRecipe.GetCost();
        }
        public static bool GetBasicRecipe(double recipeCount)
        {
            if (BasicRecipe < recipeCount) return false;
            BasicRecipe -= recipeCount;
            return true;
        }
        public static bool CanBuy(double amount)
        {
            return Balance >= amount;
        }
    }
}
