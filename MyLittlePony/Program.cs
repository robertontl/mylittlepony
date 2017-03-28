using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.createPlayers();
            game.createCards();
            game.shuffleCards();
            game.distributeCards();
            game.playRound();
            
            foreach (Card card in game.getCards())
            {
                Console.WriteLine("\nSpieler:" + card.getPlayer().getName() + "\t KartenID: " + card.getID() + "\t Kartenname: " + card.getName());

                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Eigenschaften:" + card.getProperties()[i].getValue() + " " + card.getProperties()[i].getUnit());
                }
            }
            /*
            foreach (Player player in game.getPlayers())
            {
                Console.WriteLine(player.getName());

                foreach(Card card in player.getCards())
                {

                    Console.WriteLine(card.getName());
                    Console.WriteLine(card.getPlayer());
                }
            }
            */

            Console.ReadKey();
            
        }
    }
}
