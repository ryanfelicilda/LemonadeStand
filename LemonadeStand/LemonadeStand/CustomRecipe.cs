using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CustomRecipe : BasicRecipe
    {
        private double lemonAmount;
        private double sugarAmount;
        private double iceAmount;
        public override double setting => lemonAmount * 0.3 + sugarAmount * 0.2 + iceAmount * 0.2; //More lemons means better chance to sell.
        public CustomRecipe(double lemonCount, double sugarCount, double iceCount) : base(1)
        {
            lemonAmount = lemonCount;
            sugarAmount = sugarCount;
            iceAmount = iceCount;
        }
    }
}
