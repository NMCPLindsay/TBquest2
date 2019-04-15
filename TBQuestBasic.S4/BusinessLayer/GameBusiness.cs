using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.DataLayer;
using TBQuestBasic.Models;
using TBQuestBasic.PresentationLayer;

namespace TBQuestBasic.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        Player _player = new Player();
        List<string> _messages;
        bool _newPlayer = true;
        PlayerSetupView _playerSetupView;
        Map _gameMap;
        Location _currentLocation;
        


        public GameBusiness()
        {
            _player = SetUpPlayer();
            InitializeDataSet();
            InstantiateAndShowView();
        }

        private Player SetUpPlayer()
        {
            Player player = new Player();
            if (_newPlayer)
            {
                player = SetUpNewPlayer(player);
            }
            else
            {
                player = GameData.PlayerData();
            }
            return player;
        }

        private Player SetUpNewPlayer(Player player)
        {
            _playerSetupView = new PlayerSetupView(player);
            _playerSetupView.ShowDialog();

          
            return player;
        }

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(
                _player, 
                _messages, 
                _gameMap, 
                _currentLocation
                );
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

            if (_playerSetupView.ShowActivated)
            {
                _playerSetupView.Close();
            }


        }

        private void InitializeDataSet()
        {
            
            _messages = GameData.InitialMessages(_player);
            _gameMap = GameData.GameMapData();
            _currentLocation = _gameMap.CurrentLocation;
            

        }
    }
}
