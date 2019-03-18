using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.Models;
using TBQuestBasic.DataLayer;
using System.Collections.ObjectModel;

namespace TBQuestBasic.PresentationLayer
{
    public class GameSessionViewModel
    {
        private Player _player;
        private List<string> _messages;
        private Map _gameMap;
        private Location _currentLocation;
        private ObservableCollection<Location> _accessibleLocations;
        

  

        public ObservableCollection<Location> AccessibleLocations
        {
            get { return _accessibleLocations; }
            set { _accessibleLocations = value; }
        }






        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set => _currentLocation = value;
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

        public GameSessionViewModel(Player player, List<string> initialMessages, Map gameMap, Location currentLocation)
        {

            _player = player;
            _gameMap = gameMap;
            _currentLocation = currentLocation;
            _messages = initialMessages;
            _accessibleLocations = gameMap.AccessibleLocations;
        }
    }
}
