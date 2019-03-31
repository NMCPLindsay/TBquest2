using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
    public class Ship : ObservableObject
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
        private string _shipName;
        #endregion

        #region PROPERTIES
        public string ShipName
        {
            get { return _shipName; }
            set { _shipName = value; }
        }



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
        public Ship()
        {

        }
        #endregion

    }
}
