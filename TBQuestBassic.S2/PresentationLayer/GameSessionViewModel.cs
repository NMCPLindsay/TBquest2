﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.Models;
using TBQuestBasic.DataLayer;
using System.Collections.ObjectModel;

namespace TBQuestBasic.PresentationLayer
{
    public class GameSessionViewModel : ObservableObject
    {
        private Player _player;
        private List<string> _messages = new List<string>();
        private Map _gameMap;
        private Location _currentLocation;
        private ObservableCollection<Location> _accessibleLocations;
        private Ship _playerShip;

        public Ship PlayerShip
        {
            get { return _playerShip; }
            set { _playerShip = value; }
        }





        public ObservableCollection<Location> AccessibleLocations
        {
            get
            {
                ObservableCollection<Location> _accessibleLocations = new ObservableCollection<Location>();
                _accessibleLocations = ShipRangeToDistance(_gameMap, _currentLocation, _playerShip);
                return _accessibleLocations;
            }
            set
            {
                _accessibleLocations = value;
                OnPropertyChanged(nameof(AccessibleLocations));
                ;
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

        public string FormatMessages(List<string> _messages)
        {
            return string.Join("\n\n", _messages);
        }

        
         

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player, List<string> initialMessages, Map gameMap, Location currentLocation, Ship playerShip)
        {

            _player = player;
            _gameMap = gameMap;
            _currentLocation = GameData.initialLocation(GameMap);
            _messages = initialMessages;            
            _playerShip = playerShip;
            _accessibleLocations = ShipRangeToDistance(GameMap, CurrentLocation, PlayerShip);
        }

        public static ObservableCollection<Location> ShipRangeToDistance(Map map, Location currentLocation, Ship ship)
        {

                      
            double distanceFromCurrentLocation;
            
            ObservableCollection<Location> accessibleLocations = new ObservableCollection<Location>();

            foreach (Location location in GameData.GameMapData().Locations)
            {
                if (location.DistanceFromCoruscant >= currentLocation.DistanceFromCoruscant)
                {
                    distanceFromCurrentLocation = location.DistanceFromCoruscant - currentLocation.DistanceFromCoruscant;
                    if (ship.Range >= distanceFromCurrentLocation && location.Name != currentLocation.Name)
                    {
                        accessibleLocations.Add(location);
                        location.IsAccessible = true;

                    }
                    else
                    {
                        accessibleLocations.Remove(location);
                        location.IsAccessible = false;
                    }
                }
                else if (location.DistanceFromCoruscant <= currentLocation.DistanceFromCoruscant)
                {
                    distanceFromCurrentLocation = currentLocation.DistanceFromCoruscant - location.DistanceFromCoruscant;
                    if (ship.Range >= distanceFromCurrentLocation && location.Name != currentLocation.Name)
                    {
                        accessibleLocations.Add(location);
                        location.IsAccessible = true;
                    }
                    else
                    {
                        accessibleLocations.Remove(location);
                        location.IsAccessible = false;
                    }
                }
                
            

            }
            return accessibleLocations;
        }

        public Location OnMove()
        {
           
            _currentLocation = CurrentLocation;
            _accessibleLocations = ShipRangeToDistance(GameMap, CurrentLocation, PlayerShip);
        
            return _currentLocation;
        }
    }
}
