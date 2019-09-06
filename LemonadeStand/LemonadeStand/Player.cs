using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public Inventory items;
        public double money;
        public double cup;
        public double ice;
        public double sugar;
        public double lemon;

        public Player()
        {
            items = new Inventory();
            money = 20.00;
        }
        public void MoneyBalance(Store store, Player player)
        {
            if (player.money > store.cupCost)
            {
                money -= store.CupAmount();
                cup += store.itemAmount;
            }
            else if(player.money > store.iceCost)
            {
                money -= store.IceAmount();
                ice += store.itemAmount;
            }
            else if (player.money > store.iceCost)
            {
                money -= store.SugarAmount();
                sugar += store.itemAmount;
            }
            else if (player.money > store.iceCost)
            {
                money -= store.LemonAmount();
                lemon += store.itemAmount;
            }
            else
            {
                Console.WriteLine("You don't have enough money for this item.");
            }
        }
    }
}
