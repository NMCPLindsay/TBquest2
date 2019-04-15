using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TBQuestBasic.DataLayer;
using TBQuestBasic.PresentationLayer;

namespace TBQuestBasic.Models 
{
    public class Map : ObservableObject
    {
        #region FIELDS    
        private List<Location> _locations;
        private Location _currentLocation;
        private ObservableCollection<Location> _accessibleLocations;
        private Location _initialLocation;
        private List<GameObjects> _standardGameObjects;





        #endregion

        #region PROPERTIES
        public List<GameObjects> StandardGameObjects
        {
            get { return _standardGameObjects; }
            set { _standardGameObjects = value; }
        }


        public Location InitialLocation
        {
            get { return _initialLocation; }
            set { _initialLocation = value; }
        }


        public ObservableCollection<Location> AccessibleLocations
        {
            get
            {
                
                
                return _accessibleLocations;
            }
            set
            {
                _accessibleLocations = value;
                OnPropertyChanged(nameof(AccessibleLocations));
            }
        }

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
            }
        }


        public List<Location> Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }

        
        #endregion

        #region CONSTRUCTORS

        public Map()
        {
        
        }
        
     

        #endregion

        #region METHODS
        
    

        

        


        #endregion


    }




}
