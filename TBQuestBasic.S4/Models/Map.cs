using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TBQuestBasic.DataLayer;
using TBQuestBasic.PresentationLayer;
using TBQuestBasic.Models.GameObjects;

namespace TBQuestBasic.Models
{
    public class Map : ObservableObject
    {
        #region FIELDS    
        private Location[,,] _locations;

        private ObservableCollection<Location> _accessibleLocations;
        private List<GameObject> _standardGameObjects;
        private GameMapCoordinates _currentLocationCoordinates;
        private int _maxPlanetId, _maxPLocationId, _maxBuildingId;






        #endregion

        #region PROPERTIES
        public Location CurrentLocation
        {
            get { return _locations[_currentLocationCoordinates.PlanetId, _currentLocationCoordinates.LocationId, _currentLocationCoordinates.BuildingId]; }
        }

        public GameMapCoordinates CurrentLocationCoordinates
        {
            get { return _currentLocationCoordinates; }
            set { _currentLocationCoordinates = value; }
        }

        public List<GameObject> StandardGameObjects
        {
            get { return _standardGameObjects; }
            set { _standardGameObjects = value; }
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



        public Location[,,] Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }


        #endregion

        #region CONSTRUCTORS

        public Map(int maxPlanetId, int maxPLocationId, int maxBuildingId)
        {

            _maxPlanetId = maxPlanetId;
            _maxPLocationId = maxPLocationId;
            _maxBuildingId = maxBuildingId;

        }



        #endregion

        #region METHODS

    

        




        #endregion


    }




}
