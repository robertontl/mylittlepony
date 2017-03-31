using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Game
    {
        private List<Player> _players = new List<Player>();
        private List<Card> _cards = new List<Card>();
        private Player _lastWinner;

        public Game()
        {

        }

        public void createPlayers()
        {
            _players.Add(new Player("Spieler 1", 1));
            _players.Add(new Player("Spieler 2", 2));
            _players.Add(new Player("Spieler 3", 3));
            _players.Add(new Player("Spieler 4", 4));
        }
        
        public List<Player> getPlayers()
        {
            return _players;
        }

        public void createCards()
        {
            int[] value = new int[32];
            value[0] = 156;
            value[1] = 2;
            value[2] = 70;
            value[3] = 10000;
            value[4] = 165;
            value[5] = 4;
            value[6] = 120;
            value[7] = 15000;
            value[8] = 193;
            value[9] = 4;
            value[10] = 90;
            value[11] = 9000;
            value[12] = 123;
            value[13] = 1;
            value[14] = 95;
            value[15] = 7500;
            value[16] = 175;
            value[17] = 2;
            value[18] = 70;
            value[19] = 10000;
            value[20] = 163;
            value[21] = 4;
            value[22] = 120;
            value[23] = 15250;
            value[24] = 193;
            value[25] = 4;
            value[26] = 90;
            value[27] = 4000;
            value[28] = 196;
            value[29] = 1;
            value[30] = 95;
            value[31] = 2300;

            string[] unit = new string[32];
            unit[0] = "cm";
            unit[1] = "int";
            unit[2] = "km/h";
            unit[3] = "Euro";
            unit[4] = "cm";
            unit[5] = "int";
            unit[6] = "km/h";
            unit[7] = "Euro";
            unit[8] = "cm";
            unit[9] = "int";
            unit[10] = "km/h";
            unit[11] = "Euro";
            unit[12] = "cm";
            unit[13] = "int";
            unit[14] = "km/h";
            unit[15] = "Euro";
            unit[16] = "cm";
            unit[17] = "int";
            unit[18] = "km/h";
            unit[19] = "Euro";
            unit[20] = "cm";
            unit[21] = "int";
            unit[22] = "km/h";
            unit[23] = "Euro";
            unit[24] = "cm";
            unit[25] = "int";
            unit[26] = "km/h";
            unit[27] = "Euro";
            unit[28] = "cm";
            unit[29] = "int";
            unit[30] = "km/h";
            unit[31] = "Euro";

            bool[] higherValueWins = new bool[32];
            higherValueWins[0] = true;
            higherValueWins[1] = true;
            higherValueWins[2] = true;
            higherValueWins[3] = true;
            higherValueWins[4] = true;
            higherValueWins[5] = true;
            higherValueWins[6] = true;
            higherValueWins[7] = true;
            higherValueWins[8] = true;
            higherValueWins[9] = true;
            higherValueWins[10] = true;
            higherValueWins[11] = true;
            higherValueWins[12] = true;
            higherValueWins[13] = true;
            higherValueWins[14] = true;
            higherValueWins[15] = true;
            higherValueWins[16] = true;
            higherValueWins[17] = true;
            higherValueWins[18] = true;
            higherValueWins[19] = true;
            higherValueWins[20] = true;
            higherValueWins[21] = true;
            higherValueWins[22] = true;
            higherValueWins[23] = true;
            higherValueWins[24] = true;
            higherValueWins[25] = true;
            higherValueWins[26] = true;
            higherValueWins[27] = true;
            higherValueWins[28] = true;
            higherValueWins[29] = true;
            higherValueWins[30] = true;
            higherValueWins[31] = true;

            string[] name = new string[8];
            name[0] = "Pferd 1";
            name[1] = "Pferd 2";
            name[2] = "Pferd 3";
            name[3] = "Pferd 4";
            name[4] = "Pferd 5";
            name[5] = "Pferd 6";
            name[6] = "Pferd 7";
            name[7] = "Pferd 8";

            string[] id = new string[8];
            id[0] = "A2";
            id[1] = "G4";
            id[2] = "E6";
            id[3] = "D5";
            id[4] = "A5";
            id[5] = "G7";
            id[6] = "E1";
            id[7] = "D3";

            for (int i = 0; i <= name.Length-1; i++)
            {
                List<Property> _properties = new List<Property>();

                for (int j = 0; j <= 3; j++)
                {
                    _properties.Add(new Property(value[i*4+j], unit[i*4+j], higherValueWins[i*4+j]));
                }
                _cards.Add(new Card(name[i], id[i], _properties));
            }
        }

        public List<Card> getCards()
        {
            return _cards;
        }

        public void shuffleCards()
        {
            List<Card> _shuffledCards = new List<Card>();

            Random r = new Random();

            int maxValueRandom = getCards().Count();
            
            for (int i = 0; i <= getCards().Count()+_shuffledCards.Count()-1; i++)
            { 
                int randomNumber = r.Next(0, maxValueRandom);

                if (!_shuffledCards.Contains(_cards[randomNumber]))
                {
                    _shuffledCards.Add(_cards[randomNumber]);
                    _cards.Remove(_cards[randomNumber]);
                    maxValueRandom = maxValueRandom - 1;
                }
            }

            this._cards = _shuffledCards;
        }

        public void distributeCards()
        {
            for (int i = 0; i <= getCards().Count()-1; i++)
            {
                int playerIndex = i % 4;

                this.getPlayers()[playerIndex].getCards().Add(_cards[i]);
                _cards[i].setPlayer(this.getPlayers()[playerIndex]);
            }
        }

        public void playRound()
        {
            Player p = this.getCurrentPlayer();
            this.getCurrentCardsOfAllPlayers();
            //p = this.playCard();
        }

        public Player getCurrentPlayer()
        {
            _lastWinner = this.getPlayers()[0];
            
            return _lastWinner;
        }

        /*
        public List<Player> playCard()
        {

        }
        */

        public List<Card> getCurrentCardsOfAllPlayers()
        {
            List<Card> currentCardsOfAllPlayers = new List<Card>();

            foreach (Player player in this.getPlayers())
            {
                currentCardsOfAllPlayers.Add(player.getCurrentCards().First());
            }

            return currentCardsOfAllPlayers;
        }

        /*
        public List<Player> compareCardsAndFindWinner()
        {

        }
        */
    }
}
