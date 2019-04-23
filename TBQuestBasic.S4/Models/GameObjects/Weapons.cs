using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
    public class Weapons : GameObjects
    {
        public enum Types
        {
            OneHanded,
            TwoHanded,
            Throwable
        }

        private int _weaponDamage;
        private Types _type;

        public Types Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public int WeaponDamage
        {
            get { return _weaponDamage; }
            set { _weaponDamage = value; }
        }


        public Weapons(int id, string name, int weaponDamage, Types type, string description)
            :base(id,name, description)
        {
            WeaponDamage = weaponDamage;
            Type = type;
        }

        public override string InformationString()
        {
            return $"{Name}: {Description}\nType: {Type} Damage: {WeaponDamage}";
        }

    }
}
