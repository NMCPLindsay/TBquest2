using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
    public class Ship : ObservableObject
    {
        public enum ShipClasses
        {
            Fighter,
            Bomber,
            Freighter,
            Transport

        }

        private ShipClasses _shipClass;
        private double _range;
        private string _shipName;   

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

        public Ship()
        {

        }
    }
}
