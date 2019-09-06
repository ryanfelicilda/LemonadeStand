using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.RunGame();

            Weather weather = new Weather();
            weather.SetTemp();
            weather.SetCondition();
            
            Store store = new Store();
            store.ChooseItem(game.player);

            Player player = new Player();
            player.MoneyBalance(store, player);

        }
    }
}
