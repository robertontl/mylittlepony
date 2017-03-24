using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Card
    {
        private Player _player;
        private string _name;
        private string _id;
        private List<Property> _properties = new List<Property>();

        public Card(string name, string id, List<Property> property)
        {
            this.setName(name);
            this.setID(id);
            this._properties = property;
        }

        public Player getPlayer()
        {
            return this._player;
        }

        public void setPlayer(Player player)
        {
            this._player = player;
        }

        public string getName()
        {
            return this._name;
        }

        public void setName(string name)
        {
            this._name = name;
        }

        public string getID()
        {
            return this._id;
        }

        public void setID(string ID)
        {
            this._id = ID;
        }

        public List<Property> getProperties()
        {
            return _properties;
        }
    }
}
