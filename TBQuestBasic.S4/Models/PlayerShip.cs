using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models.NPC
{
    public class PlayerShip : Character
    {
        #region ENUMS
        public enum ShipTypes
        {
            Frieghter,
            Personnel,
            Fighter
        }
        #endregion

        #region FIELDS
        private ShipTypes _shipType;
        private string _shipDescription;
        private double _shipHealth;
        private double _shipShields;
        private int _shipLevel;

   


        #endregion

        #region PROPERTIES
        public ShipTypes ShipType
        {
            get { return _shipType; }
            set { _shipType = value; }
        }

        public string ShipDescription
        {
            get { return _shipDescription; }
            set { _shipDescription = value; }
        }

        public double ShipHealth
        {
            get { return _shipHealth; }
            set { _shipHealth = value; }
        }

        public double ShipShields
        {
            get { return _shipShields; }
            set { _shipShields = value; }
        }

        public int ShipLevel
        {
            get { return _shipLevel; }
            set { _shipLevel = value; }
        }
        #endregion

        #region CONTRUCTORS
        public PlayerShip()
        {

        }
        #endregion

        #region METHODS

        #endregion
    }
}
