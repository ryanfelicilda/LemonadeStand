using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public static double MaxPrice => 5;
        public bool GonnaBuy(double price)
        {
            return new Random().Next(1, 100) / 100d > price / MaxPrice;
        }
    }
}
