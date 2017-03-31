using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Player
    {
        public int _id;
        public string _name;
        private List<Card> _cards = new List<Card>();

        public Player(string name, int ID)
        {
            this.setName(name);
            this.setID(ID);
        }

        public string getName()
        {
            return this._name;
        }

        public void setName(string name)
        {
            this._name = name;
        }

        public int getID()
        {
            return this._id;
        }

        public void setID(int ID)
        {
            this._id = ID;
        }

        public List<Card> getCards()
        {
            return this._cards;
        }

        public void playCard()
        {
            this.getCurrentCard();
            //this.chooseProperty();
        }

        public Card getCurrentCard()
        {
            Card topCardOfCurrentPlayer = this._cards.First();
            return topCardOfCurrentPlayer;
        }

        public Property chooseProperty()
        {
            List<Property> propertiesOfTopCardOfCurrentPlayer = new List<Property>();

            propertiesOfTopCardOfCurrentPlayer = this.getCurrentCard().getProperties();

            Console.WriteLine("Hallo " + this.getCurrentCard().getPlayer().getName());
            Console.WriteLine("Deine oberste Karte:\n");
            Console.WriteLine("Name: " + this.getCurrentCard().getName());
            Console.WriteLine("Eigenschaften:\n");

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("[" + i + "] " + propertiesOfTopCardOfCurrentPlayer[i].getValue() + " " + propertiesOfTopCardOfCurrentPlayer[i].getUnit());
            }

            Console.WriteLine("Wähle eine Property aus.");
            int propertyIndex = Convert.ToInt32(Console.ReadLine());

            Property choosenProperty = this.getCurrentCard().getProperties()[propertyIndex];

            return choosenProperty;
        }

        public void countCards()
        {

        }
    }
}

