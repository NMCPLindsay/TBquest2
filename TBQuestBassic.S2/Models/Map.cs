using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TBQuestBasic.DataLayer;

namespace TBQuestBasic.Models
{
    public class Map 
    {
        private ObservableCollection<Location> _locations;
        private Location _currentLocation;


        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }


        public ObservableCollection<Location> Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }

        public ObservableCollection<Location> AccessibleLocations
        {
            get
            {
                Move();
                ObservableCollection<Location> accessibleLocations = new ObservableCollection<Location>();
                foreach (var location in Locations)
                {
                    if (_currentLocation.DistanceFromCoruscant > location.DistanceFromCoruscant)
                    {
                        double distance = _currentLocation.DistanceFromCoruscant - location.DistanceFromCoruscant;
                        location.IsAccessible = IsAccessibleLocation(distance);
                    }
                    else if (_currentLocation.DistanceFromCoruscant < location.DistanceFromCoruscant)
                    {
                        double distance = location.DistanceFromCoruscant - _currentLocation.DistanceFromCoruscant;
                        location.IsAccessible = IsAccessibleLocation(distance);
                    }
                    accessibleLocations.Add(location);
                }
                return accessibleLocations;
            }
        }
        internal static bool IsAccessibleLocation(double distance)
        {
            Ship playerShip = GameData.ShipData();

            if (distance > playerShip.Range)
            {
                return false;
            }
            else if (distance <= playerShip.Range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Move(Location location)
        {
            _currentLocation = GameData.InitialGameMapLocation();

        }
	

	}



    
}
