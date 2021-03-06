﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.Models;
using TBQuestBasic.DataLayer;
using System.Collections.ObjectModel;
using TBQuestBasic.Models.GameObjects;
using TBQuestBasic.Models.Interface;
using TBQuestBasic.Models.NPC;

namespace TBQuestBasic.PresentationLayer
{
    public class GameSessionViewModel : ObservableObject
    {

        #region FIELDS

        private Player _player;
        private List<string> _messages = new List<string>();
        private Map _gameMap;
        private Location _currentLocation;
        private ObservableCollection<Location> _accessibleLocations;
        private Location _initialLocation;
        private Location _nextPlanetLocation;
        private Location _previousPlanetLocation;
        private Location _nextPlanet;
        private Location _building1;
        private Location _building2;
        private Location _building3;
        private Location _building4;
        private Location _previousPlanet;
        private GameObjectQuantity _currentGameObject;
        private NPC _currentNPC;
        private Armor _currentHelm;
        private Armor _currentChest;
        private Armor _currentLegs;
        private Armor _currentHands;
        private Armor _currentFeet;
        private Weapons _currentWeapon;

        #endregion

        #region PROPERTIES

        public Weapons CurrentWeapon
        {
            get { return _currentWeapon; }
            set { _currentWeapon = value; OnPropertyChanged(nameof(CurrentWeapon)); }
        }

        public Armor CurrentFeet
        {
            get { return _currentFeet; }
            set { _currentFeet = value; OnPropertyChanged(nameof(CurrentFeet)); }
        }

        public Armor CurrentHands
        {
            get { return _currentHands; }
            set { _currentHands = value; OnPropertyChanged(nameof(CurrentHands)); }
        }

        public Armor CurrentLegs
        {
            get { return _currentLegs; }
            set { _currentLegs = value; OnPropertyChanged(nameof(CurrentLegs)); }
        }


        public Armor CurrentChest
        {
            get { return _currentChest; }
            set { _currentChest = value; OnPropertyChanged(nameof(CurrentChest)); }
        }


        public Armor CurrentHelm
        {
            get { return _currentHelm; }
            set
            {
                _currentHelm = value;
                OnPropertyChanged(nameof(CurrentHelm));
            }
        }

        public NPC CurrentNPC
        {
            get { return _currentNPC; }
            set
            {
                _currentNPC = value;
                OnPropertyChanged(nameof(CurrentNPC));
            }
        }

        public GameObjectQuantity CurrentGameObject
        {
            get { return _currentGameObject; }
            set
            {
                _currentGameObject = value;
                OnPropertyChanged(nameof(_currentGameObject));
            }
        }

        public Location PreviousPlanet
        {
            get { return _previousPlanet; }
            set
            {
                _previousPlanet = value;
                OnPropertyChanged(nameof(PreviousPlanet));
            }
        }

        public Location Building4
        {
            get { return _building4; }
            set
            {
                _building4 = value;
                OnPropertyChanged(nameof(Building4));
            }
        }



        public Location Building3
        {
            get { return _building3; }
            set
            {
                _building3 = value;
                OnPropertyChanged(nameof(Building3));
            }
        }


        public Location Building2
        {
            get { return _building2; }
            set
            {
                _building2 = value;
                OnPropertyChanged(nameof(Building2));
            }
        }


        public Location Building1
        {
            get { return _building1; }
            set
            {
                _building1 = value;
                OnPropertyChanged(nameof(Building1));

            }
        }



        public Location NextPlanet
        {
            get { return _nextPlanet; }
            set
            {
                _nextPlanet = value;
                OnPropertyChanged(nameof(NextPlanet));
            }
        }


        public Location PreviousPlanetLocation
        {
            get { return _previousPlanetLocation; }
            set
            {
                _previousPlanetLocation = value;
                OnPropertyChanged(nameof(PreviousPlanetLocation));
            }
        }


        public Location NextPlanetLocation

        {
            get { return _nextPlanetLocation; }
            set
            {

                _nextPlanetLocation = value;
                OnPropertyChanged(nameof(NextPlanetLocation));
            }
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
            get
            {

                return _currentLocation;
            }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
            }
        }


        public Map GameMap
        {
            get { return _gameMap; }
            set { _gameMap = value; }
        }

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return FormatMessages(_messages); }

        }

        public bool HasNextPlanet { get { return NextPlanet != null; } }
        public bool HasPreviousPlanet { get { return PreviousPlanet != null; } }
        public bool HasNextLocation { get { return NextPlanetLocation != null; } }
        public bool HasPreviousLocation { get { return PreviousPlanetLocation != null; } }
        public bool HasBuilding1 { get { return Building1 != null; } }
        public bool HasBuilding2 { get { return Building2 != null; } }
        public bool HasBuilding3 { get { return Building3 != null; } }
        public bool HasBuilding4 { get { return Building4 != null; } }




        #endregion

        #region CONSTRUCTORS
        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player, List<string> initialMessages, Map gameMap, GameMapCoordinates currentLocationCoordinates)
        {

            _player = player;
            _gameMap = gameMap;

            _gameMap.CurrentLocationCoordinates = currentLocationCoordinates;
            _currentLocation = gameMap.CurrentLocation;
            _messages = initialMessages;

            _accessibleLocations = gameMap.AccessibleLocations;

        }
        #endregion

        #region METHODS
        public string FormatMessages(List<string> _messages)
        {
            return string.Join("\n\n", _messages);
        }
                                 
        public void OnMove()
        {

        }

        private void UpdateAvailableLocations()
        {
            NextPlanet = null;
            PreviousPlanet = null;
            NextPlanetLocation = null;
            PreviousPlanetLocation = null;
            Building1 = null;
            Building2 = null;
            Building3 = null;
            Building4 = null;

            if (_gameMap.NextPlanet() != null)
            {
                Location nextPlanet = _gameMap.NextPlanet();
                NextPlanet = nextPlanet;
            }

            if (_gameMap.PreviousPlanet() != null)
            {
                Location previousPlanet = _gameMap.PreviousPlanet();
                PreviousPlanet = previousPlanet;
            }

            if (_gameMap.NextLocation() != null)
            {
                Location nextLocation = _gameMap.NextLocation();
                NextPlanetLocation = nextLocation;
            }

            if (_gameMap.PreviousLocation() != null)
            {
                Location previousLocation = _gameMap.PreviousLocation();
                PreviousPlanetLocation = previousLocation;
            }

            if (_gameMap.Building1Location() != null)
            {
                Location building1 = _gameMap.Building1Location();
                Building1 = building1;
            }

            if (_gameMap.Building2Location() != null)
            {
                Location building2 = _gameMap.Building2Location();
                Building2 = building2;
            }

            if (_gameMap.Building3Location() != null)
            {
                Location building3 = _gameMap.Building3Location();
                Building3 = building3;
            }

            if (_gameMap.Building4Location() != null)
            {
                Location building4 = _gameMap.Building4Location();
                Building4 = building4;
            }
        }

        public void ExitBuilding()
        {
            if (_gameMap.CurrentLocationCoordinates.BuildingId > 0 )
            {
                _gameMap.CurrentLocationCoordinates.BuildingId = 0;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
           

        }

        public void EnterBuilding1()
        {
            if (HasBuilding1)
            {
                _gameMap.CurrentLocationCoordinates.BuildingId = 1;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
            
        }

        public void EnterBuilding2()
        {
            if (HasBuilding2)
            {
                _gameMap.CurrentLocationCoordinates.BuildingId = 2;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
          
        }

        public void EnterBuilding3()
        {
            if (HasBuilding3)
            {
                _gameMap.CurrentLocationCoordinates.BuildingId = 3;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
          
        }

        public void EnterBuilding4()
        {
            if (HasBuilding4)
            {
                _gameMap.CurrentLocationCoordinates.BuildingId = 4;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
            
        }

        public void MoveToPreviousPlanetLocation()
        {
            if (HasPreviousLocation)
            {
                _gameMap.CurrentLocationCoordinates.LocationId -= 1;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
            
        }
        public void MoveToNextPlanetLocation()
        {
            if (HasNextLocation)
            {
                _gameMap.CurrentLocationCoordinates.LocationId += 1;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
            
        }
        public void MoveToNextPlanet()
        {
            if (HasNextPlanet)
            {
                _gameMap.CurrentLocationCoordinates.LocationId = 0;
                _gameMap.CurrentLocationCoordinates.BuildingId = 0;
                _gameMap.CurrentLocationCoordinates.PlanetId += 1;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
           
        }
        public void MoveToPreviousPlanet()
        {
            if (HasPreviousPlanet)
            {
                _gameMap.CurrentLocationCoordinates.LocationId = 0;
                _gameMap.CurrentLocationCoordinates.BuildingId = 0;
                _gameMap.CurrentLocationCoordinates.PlanetId -= 1;
                CurrentLocation = _gameMap.CurrentLocation;
                UpdateAvailableLocations();
            }
            
        }
        public void AddObjectToInventory()
        {
            //
            // confirm a game item selected and is in current location
            // subtract from location and add to inventory
            //
            if (_currentGameObject != null && _currentLocation.GameObjects.Contains(_currentGameObject))
            {
                //
                // cast selected game item 
                //
                GameObjectQuantity selectedGameItemQuantity = _currentGameObject as GameObjectQuantity;

                _currentLocation.RemoveGameItemQuantityFromLocation(selectedGameItemQuantity);
                _player.AddGameItemQuantityToInventory(selectedGameItemQuantity);

                
            }
        }
        public void RemoveItemFromInventory()
        {
            //
            // confirm a game item selected and is in inventory
            // subtract from inventory and add to location
            //
            if (_currentGameObject != null)
            {
                //
                // cast selected game item 
                //
                GameObjectQuantity selectedGameObjectQuantity = _currentGameObject as GameObjectQuantity;

                _currentLocation.AddGameObjectQuantityToLocation(selectedGameObjectQuantity);
                _player.RemoveGameItemQuantityFromInventory(selectedGameObjectQuantity);

                
            }
        }

        public void OnUseGameItem()
        {
            switch (_currentGameObject.GameObject)
            {
                case Elixirs elixir:
                    ProcessElixirUse(elixir);
                    break;
                
                default:
                    break;
            }
        }

        private void ProcessElixirUse(Elixirs elixir)
        {
            _player.HitPoints += elixir.HealthChange;
            _player.RemoveGameItemQuantityFromInventory(_currentGameObject);
        }
        public void EquipObject()
        {
            if (_currentGameObject != null)
            {
                GameObject selectedGameObject = _currentGameObject.GameObject;

                if (selectedGameObject is Weapons)
                {
                    Weapons equippedWeapon = selectedGameObject as Weapons;
                  
                   
                        _currentWeapon = equippedWeapon;
                        _player.RemoveGameItemQuantityFromInventory(_currentGameObject);
                    
               
                    
                    
                }
                if (selectedGameObject is Armor)
                {
                    Armor equippedArmor = selectedGameObject as Armor;
                    switch (equippedArmor.Type)
                    {
                        case Armor.Types.Headgear:
                            _currentHelm = equippedArmor;
                            break;
                        case Armor.Types.Chest:
                            _currentChest = equippedArmor;
                            break;
                        case Armor.Types.Legs:
                            _currentLegs = equippedArmor;
                            break;
                        case Armor.Types.Hands:
                            _currentHands = equippedArmor;
                            break;
                        case Armor.Types.Feet:
                            CurrentFeet = equippedArmor;
                            break;
                        default:
                            break;
                    }
                   
                }
            }
        }
        #endregion


    }
}
