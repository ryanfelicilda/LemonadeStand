using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    interface IDay
    {
        void CheckWeather(Weather weather);
        void BuyIngredients();
        BasicRecipe CreateProduct();
        void SellProduct(BasicRecipe product, Weather weather);
    }
}
