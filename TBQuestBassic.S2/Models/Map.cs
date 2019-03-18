using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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
                ObservableCollection<Location> accessibleLocations = new ObservableCollection<Location>();
                foreach (var location in _locations)
                {
                    if (location.IsAccessible == true)
                    {
                        accessibleLocations.Add(location);
                    }
                }
                return accessibleLocations;
            }
        }
       

        public void Move(Location location)
        {
            _currentLocation = location;

        }
	

	}



    
}
