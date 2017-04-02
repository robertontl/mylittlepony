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
            int[] value = new int[64];
            value[0] = 156;
            value[1] = 4;
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
            value[13] = 4;
            value[14] = 95;
            value[15] = 7500;
            value[16] = 175;
            value[17] = 4;
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
            value[29] = 4;
            value[30] = 95;
            value[31] = 2300;
            value[32] = 156;
            value[33] = 4;
            value[34] = 70;
            value[35] = 10000;
            value[36] = 165;
            value[37] = 4;
            value[38] = 120;
            value[39] = 15000;
            value[40] = 193;
            value[41] = 4;
            value[42] = 90;
            value[43] = 9000;
            value[44] = 123;
            value[45] = 4;
            value[46] = 95;
            value[47] = 7500;
            value[48] = 175;
            value[49] = 4;
            value[50] = 70;
            value[51] = 10000;
            value[52] = 163;
            value[53] = 4;
            value[54] = 120;
            value[55] = 15250;
            value[56] = 193;
            value[57] = 4;
            value[58] = 90;
            value[59] = 4000;
            value[60] = 196;
            value[61] = 4;
            value[62] = 95;
            value[63] = 2300;

            string[] unit = new string[64];
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
            unit[32] = "cm";
            unit[33] = "int";
            unit[34] = "km/h";
            unit[35] = "Euro";
            unit[36] = "cm";
            unit[37] = "int";
            unit[38] = "km/h";
            unit[39] = "Euro";
            unit[40] = "cm";
            unit[41] = "int";
            unit[42] = "km/h";
            unit[43] = "Euro";
            unit[44] = "cm";
            unit[45] = "int";
            unit[46] = "km/h";
            unit[47] = "Euro";
            unit[48] = "cm";
            unit[49] = "int";
            unit[50] = "km/h";
            unit[51] = "Euro";
            unit[52] = "cm";
            unit[53] = "int";
            unit[54] = "km/h";
            unit[55] = "Euro";
            unit[56] = "cm";
            unit[57] = "int";
            unit[58] = "km/h";
            unit[59] = "Euro";
            unit[60] = "cm";
            unit[61] = "int";
            unit[62] = "km/h";
            unit[63] = "Euro";

            bool[] higherValueWins = new bool[64];
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
            higherValueWins[32] = true;
            higherValueWins[33] = true;
            higherValueWins[34] = true;
            higherValueWins[35] = true;
            higherValueWins[36] = true;
            higherValueWins[37] = true;
            higherValueWins[38] = true;
            higherValueWins[39] = true;
            higherValueWins[40] = true;
            higherValueWins[41] = true;
            higherValueWins[42] = true;
            higherValueWins[43] = true;
            higherValueWins[44] = true;
            higherValueWins[45] = true;
            higherValueWins[46] = true;
            higherValueWins[47] = true;
            higherValueWins[48] = true;
            higherValueWins[49] = true;
            higherValueWins[50] = true;
            higherValueWins[51] = true;
            higherValueWins[52] = true;
            higherValueWins[53] = true;
            higherValueWins[54] = true;
            higherValueWins[55] = true;
            higherValueWins[56] = true;
            higherValueWins[57] = true;
            higherValueWins[58] = true;
            higherValueWins[59] = true;
            higherValueWins[60] = true;
            higherValueWins[61] = true;
            higherValueWins[62] = true;
            higherValueWins[63] = true;

            string[] name = new string[16];
            name[0] = "Pferd 1";
            name[1] = "Pferd 2";
            name[2] = "Pferd 3";
            name[3] = "Pferd 4";
            name[4] = "Pferd 5";
            name[5] = "Pferd 6";
            name[6] = "Pferd 7";
            name[7] = "Pferd 8";
            name[8] = "Pferd 9";
            name[9] = "Pferd 10";
            name[10] = "Pferd 11";
            name[11] = "Pferd 12";
            name[12] = "Pferd 13";
            name[13] = "Pferd 14";
            name[14] = "Pferd 15";
            name[15] = "Pferd 16";

            string[] id = new string[16];
            id[0] = "A1";
            id[1] = "B3";
            id[2] = "C2";
            id[3] = "D3";
            id[4] = "E2";
            id[5] = "F5";
            id[6] = "G1";
            id[7] = "H5";
            id[8] = "A6";
            id[9] = "B2";
            id[10] = "C1";
            id[11] = "D6";
            id[12] = "E8";
            id[13] = "F3";
            id[14] = "G2";
            id[15] = "H4";

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

            p.playCard();

            List<Card> currentCards = new List<Card>();
            currentCards = this.getCurrentCardsOfAllPlayers();

            Property choosenProperty = p.chooseProperty();

            Player winner = this.compareCardsAndFindWinner(currentCards, choosenProperty);
            this._lastWinner = winner;

            Console.WriteLine("Folgender Spieler hat die Runde gewonnen: " + winner.getName());
        }

        public Player getCurrentPlayer()
        {
            Player currentPlayer = this.getPlayers()[0];

            if(_lastWinner != null)
            {
                currentPlayer = _lastWinner;
            }

            return currentPlayer;
        }

        public List<Card> getCurrentCardsOfAllPlayers()
        {
            List<Card> currentCardsOfAllPlayers = new List<Card>();

            foreach (Player player in this.getPlayers())
            {
                if (player.getCards().Count() != 0)
                { 
                    currentCardsOfAllPlayers.Add(player.getCurrentCard());
                }
            }

            return currentCardsOfAllPlayers;
        }

        public Player compareCardsAndFindWinner(List<Card> currentCards, Property choosenProperty)
        {
            Player winnerOfThisRound = this._players[0];

            int bestValue = 0;
            Card bestCard = currentCards[0];

            foreach (Card card in currentCards)
            {
                foreach (Property property in card.getProperties())
                {
                    if (property.getUnit() == choosenProperty.getUnit())
                    {
                        if (bestValue < property.getValue())
                        {
                            bestValue = property.getValue();
                            bestCard = card;
                        }                        
                        else if(bestValue == property.getValue())
                        {
                            if (bestCard.getID()[1] < card.getID()[1])
                            {
                                bestCard = card;
                            }
                            else if(bestCard.getID()[1] == card.getID()[1])
                            {
                                if (bestCard.getID()[0] < card.getID()[0])
                                { 
                                    bestCard = card;
                                }
                            }
                        }
                    }
                }
            }

            winnerOfThisRound = bestCard.getPlayer();

            foreach (Card card in currentCards)
            {
                card.getPlayer().getCards().Remove(card);
                card.setPlayer(winnerOfThisRound);
                winnerOfThisRound.getCards().Add(card);
            }

            Console.WriteLine("Größter Wert: " + bestValue + " " + choosenProperty.getUnit() + " KartenID: " + bestCard.getID());

            return winnerOfThisRound;
        }
        
        public bool hasEveryPlayerEnoughCards()
        {
            bool isTheGameStillOn = true;

            List<Player> eliminatedPlayer = new List<Player>();

            for (int i = 0; i <= _players.Count()-1; i++)
            {
                if (_players[i].countCards(_players[i]) == 0)
                {
                    eliminatedPlayer.Add(_players[i]);
                }
            }

            if (eliminatedPlayer.Count() == 3)
            {
                isTheGameStillOn = false;
            }

            return isTheGameStillOn;
        }
    }
}
