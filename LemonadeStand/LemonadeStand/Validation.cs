using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Validation
    {
        public static double ReadDoubleLine()
        {
            double res = 0;
            while (!double.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Invalid Entry. Try again.");
            }
            return res;
        }

        public static int ReadUserInput(int maxOption)
        {
            int res = 0;
            while (!int.TryParse(Console.ReadLine(), out res) || (res < 1 || res > maxOption))
            {
                Console.WriteLine("Invalid Entry. Try again.");
            }
            return res;
        }
    }
}
