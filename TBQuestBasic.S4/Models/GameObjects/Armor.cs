using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
   public class Armor : GameObjects
    {

        public enum Types
        {
            Headgear,
            Chest,
            Legs,
            Hands,
            Feet
        }
        private Types _type;
        private int _armorValue;


        public int ArmorValue
        {
            get { return _armorValue; }
            set { _armorValue = value; }
        }



        public Types Type
        {
            get { return _type; }
            set { _type = value; }
        }



        public Armor(int id, string name, int armorValue, Types type, string description)
            :base(id, name, description)
        {
            ArmorValue = armorValue;
        }



        public override string InformationString()
        {
            return $"{Name}: {Description}\nArmor: {Type} {ArmorValue}";
        }
    }
}
