using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models 
{
    public class Location : ObservableObject
    {
        #region FIELDS
        private int _id;
        private string _name;
        private string _description;
        private bool _isAccessible;
        private double _distanceFromCoruscant;
        #endregion

        #region PROPERTIES
        public double DistanceFromCoruscant
        {
            get { return _distanceFromCoruscant; }
            set { _distanceFromCoruscant = value; }
        }



        public bool IsAccessible
        {
            get { return _isAccessible; }
            set
            {
                _isAccessible = value;

            }
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
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
        #endregion

        #region CONSTRUCTORS

        public Location()
        {

        }

        #endregion

        #region METHODS
        public override string ToString()
        {
            return _name;
        }

        #endregion


    }
}
