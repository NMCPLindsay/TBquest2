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
            _locations = new Location[maxPlanetId, maxPLocationId, _maxBuildingId];

        }



        #endregion

        #region METHODS

        #region MOVEMENT



        public Location NextPlanet()
        {
            Location NextPlanet = null;

            if (_currentLocationCoordinates.PlanetId <_maxPlanetId && CurrentLocation.CanHaveShip)
            {
                Location nextPlanetLocation = _locations[_currentLocationCoordinates.PlanetId + 1, _currentLocationCoordinates.LocationId =0 , _currentLocationCoordinates.BuildingId =0 ];

                if (nextPlanetLocation != null && nextPlanetLocation.CanHaveShip)
                {
                    NextPlanet = nextPlanetLocation;
                }

            }
            return NextPlanet;
        }

        public Location PreviousPlanet()
        {
            Location PreviousPlanet = null;

            if (_currentLocationCoordinates.PlanetId > 0 && CurrentLocation.CanHaveShip)
            {
                Location previousPlanetLocation = _locations[_currentLocationCoordinates.PlanetId - 1, _currentLocationCoordinates.LocationId, _currentLocationCoordinates.BuildingId = 0];

                if (previousPlanetLocation != null && previousPlanetLocation.CanHaveShip)
                {
                    PreviousPlanet = previousPlanetLocation;
                }

            }
            return PreviousPlanet;
        }

        public Location NextLocation()
        {
            Location NextLocation = null;

            if (_currentLocationCoordinates.LocationId < _maxPLocationId && _currentLocationCoordinates.BuildingId == 0)
            {
                Location nextPlanetLocation = _locations[_currentLocationCoordinates.PlanetId, _currentLocationCoordinates.LocationId + 1 , _currentLocationCoordinates.BuildingId];

                if (nextPlanetLocation != null)
                {
                    NextLocation = nextPlanetLocation;
                }

            }
            return NextLocation;           
        }

        public Location PreviousLocation()
        {
            Location PreviousPLocation = null;

            if (_currentLocationCoordinates.LocationId >= 2 && _currentLocationCoordinates.BuildingId == 0)
            {
                Location previousPlanetLocation = _locations[_currentLocationCoordinates.PlanetId, _currentLocationCoordinates.LocationId -1, _currentLocationCoordinates.BuildingId];

                if (previousPlanetLocation != null)
                {
                    PreviousPLocation = previousPlanetLocation;
                }

            }
            return PreviousPLocation;
        }

        public Location Building1Location()
        {
            Location Building = null;

            if (_currentLocationCoordinates.BuildingId == 0)
            {
                Location checkBuilding= _locations[_currentLocationCoordinates.PlanetId , _currentLocationCoordinates.LocationId, _currentLocationCoordinates.BuildingId + 1];

                if (checkBuilding!= null)
                {
                    Building= checkBuilding;
                }

            }
            return Building;
        }

        public Location Building2Location()
        {
            Location Building = null;

            if (_currentLocationCoordinates.BuildingId == 0)
            {
                Location checkBuilding = _locations[_currentLocationCoordinates.PlanetId, _currentLocationCoordinates.LocationId, _currentLocationCoordinates.BuildingId + 2];

                if (checkBuilding != null)
                {
                    Building = checkBuilding;
                }

            }
            return Building;
        }

        public Location Building3Location()
        {
            Location Building = null;

            if (_currentLocationCoordinates.BuildingId == 0)
            {
                Location checkBuilding = _locations[_currentLocationCoordinates.PlanetId, _currentLocationCoordinates.LocationId, _currentLocationCoordinates.BuildingId + 3];

                if (checkBuilding != null)
                {
                    Building = checkBuilding;
                }

            }
            return Building;
        }

        public Location Building4Location()
        {
            Location Building = null;

            if (_currentLocationCoordinates.BuildingId == 0)
            {
                Location checkBuilding = _locations[_currentLocationCoordinates.PlanetId, _currentLocationCoordinates.LocationId, _currentLocationCoordinates.BuildingId +4];

                if (checkBuilding != null)
                {
                    Building = checkBuilding;
                }

            }
            return Building;
        }

        #endregion






        #endregion


    }




}
