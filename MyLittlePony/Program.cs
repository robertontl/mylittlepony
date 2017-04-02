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

            while (game.hasEveryPlayerEnoughCards())
            {
                game.playRound();
            }

            if (game.hasEveryPlayerEnoughCards() == false)
            {
                Console.WriteLine("Spiel vorbei.");
            }

            Console.ReadKey();
        }
    }
}
