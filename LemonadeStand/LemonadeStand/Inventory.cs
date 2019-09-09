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
        public static double Balance
        {
            get => Math.Round(money, 2);
            private set
            {
                money = value;
            }
        }
    }
}
