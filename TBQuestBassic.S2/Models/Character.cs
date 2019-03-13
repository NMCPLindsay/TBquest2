using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
    public abstract class Character
    {
        public enum Races
        {
            Mandalorian,
            Human,
            Wookie
        }


        private int _id;
        private string _name;
        private int _locationId;
        private Races _race;


       

        public Races Race
        {
            get { return _race; }
            set { _race = value; }
        }


        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }
                     

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public abstract string GetPlayerBio(Player player);

        public virtual string GetPlayerGreeting(Player player)
        {
            return "Hello! How can I assist you?";
        }










    }
}
