using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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
        private ObservableCollection<GameObjectQuantity> _gameObjects;

        private double _distanceFromTattooine;
        private double _distanceFromHoth;

   








        #endregion

        #region PROPERTIES
        public ObservableCollection<GameObjectQuantity> GameObjects
        {
            get { return _gameObjects; }
            set { _gameObjects = value; }
        }


        public double DistanceFromHoth
        {
            get { return _distanceFromHoth; }
            set { _distanceFromHoth = value; }
        }



        public double DistanceFromTattooine
        {
            get { return _distanceFromTattooine; }
            set { _distanceFromTattooine = value; }
        }


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
