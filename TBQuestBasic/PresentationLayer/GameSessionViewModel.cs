using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.Models;
using TBQuestBasic.DataLayer;

namespace TBQuestBasic.PresentationLayer
{
    public class GameSessionViewModel
    {
        private Player _player;
        private List<string> _messages = GameData.InitialMessages();
        


        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return FormatMessages(); }
           
        }

        public string FormatMessages()
        {
            return string.Join("\n\n", _messages);
        }

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player, List<string> initialMessages)
        {

            _player = player;
            

        }
    }
}
