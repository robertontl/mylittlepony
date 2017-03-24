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
        private int _lastWinner;

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
            int[] value = new int[16];
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

            string[] unit = new string[16];
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

            bool[] higherValueWins = new bool[16];
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

            string[] name = new string[4];
            name[0] = "Pferd 1";
            name[1] = "Pferd 2";
            name[2] = "Pferd 3";
            name[3] = "Pferd 4";

            string[] id = new string[4];
            id[0] = "A2";
            id[1] = "G4";
            id[2] = "E6";
            id[3] = "D5";

            for (int i = 0; i <= 3; i++)
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

            int maxValueRandom = 4;
            
            for (int i = 0; i <= 3; i++)
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
            _players = this.getPlayers();

            for (int i = 0; i <= 3; i++)
            {
                int playerIndex = i % 4;

                _players[playerIndex].getCards().Add(_cards[i]);
                _cards[i].setPlayer(_players[playerIndex]);
            }
        }
    }
}
