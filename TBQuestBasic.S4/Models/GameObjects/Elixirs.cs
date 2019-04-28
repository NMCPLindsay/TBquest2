using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models.GameObjects
{
    public class Elixirs:GameObject
    {

        private int _healthChange;
      




        public int HealthChange
        {
            get { return _healthChange; }
            set { _healthChange = value; }
        }


        public Elixirs(int id, string name, string description, int healthChange)
            : base(id, name, description)
        {
            HealthChange = healthChange;

        }

        public override string InformationString()
        {
            return $"{Name}: {Description}\nHealth: {HealthChange}";
        }


    }
}
