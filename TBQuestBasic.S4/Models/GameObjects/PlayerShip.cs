using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
    public class PlayerShip : GameObjects
    {
        #region ENUMS
        public enum ShipClasses
        {
            Fighter,
            Bomber,
            Freighter,
            Transport


        }
        #endregion

        #region FIELDS
        private ShipClasses _shipClass;
        private double _range;
      
        #endregion

        #region PROPERTIES
  



        public double Range
        {
            get { return _range; }
            set { _range = value; }
        }


        public ShipClasses ShipClass
        {
            get { return _shipClass; }
            set { _shipClass = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public PlayerShip(int id, string name, double range, string description, ShipClasses shipClass)
            :base(id, name, description)
        {
            ShipClass = shipClass;
            Range = range;

        }
        #endregion

        #region METHODS
        public override string InformationString()
        {
            return $"{Name}: {Description}\nClass: {ShipClass} Range: {Range}";
        }
        #endregion


    }
}
