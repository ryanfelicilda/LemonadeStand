using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class BasicRecipe
    {
        public static double LemonCount { get; } = .3;
        public static double SugarCount { get; } = .3;
        public static double IceCount { get; } = .3;
        private double total;
        public virtual double xxxxx => total * 0.1;
        public BasicRecipe(double amount)
        {
            total = amount;
        }
        public static double GetCost()
        {
            return LemonCount * Store.LemonPrice + SugarCount * Store.SugarPrice + IceCount * Store.IcePrice;
        }
    }
}
