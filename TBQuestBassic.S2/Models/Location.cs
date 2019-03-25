using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models 
{
    public class Location : ObservableObject
    {
        private int _id;
        private string _name;
        private string _description;
        private bool _isAccessible;
        private double _distanceFromCoruscant;

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





    }
}
