using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.Models;
using System.Collections.ObjectModel;

namespace TBQuestBasic.DataLayer
{
    public class GameData
    {

        public static Player PlayerData()
        {
            
            return new Player()
            {
                Id = 1,
                Name = "Jugo Sabine",
                LocationId = 0,
                Race = Character.Races.Mandalorian,
                Align = Player.Alignments.Evil,
                Level = 1,
                HitPoints = 100,
                EXP = 0,
                Bio = "The mandalorians were a proud race of bounty hunters. The most famous of which are the late Jango Fett and his son, Boba Fett.",
                ImgFileName = @"C:\Users\phili\Desktop\Application Dev\TBQuestBasic\TBQuestBassic\Assets\mandolorain.jpg"

            };



        }

        public static List<string> InitialMessages(Player player)
        {
            return new List<string>
            {
                $"Hello, {player.Name}. You have been selected to search and apprehend or eliminate contracts from clients of Bounty Force.",
                "Please see the Mission Briefer for your mission and good luck. Do not disappoint."


            };


        }
        public static Map GameMapData()
        {
            Map gameMap = new Map();
            ObservableCollection<Location> locations = new ObservableCollection<Location>()
            {
                new Location()
                {
                    Id = 1,
                    Name = "Tatooine",
                    Description = "A desert planet in the outer banks of the glactic republic.",
                    IsAccessable = true

                }


                

            };
            gameMap.Locations = locations;
            return gameMap;


        }
        public static Location InitialGameMapLocation()
        {
            return new Location()
            {
                Id = 1,
                Name = "Tatooine",
                Description = "A desert planet in the outer banks of the glactic republic.",
                IsAccessable = true

            };

        }
        








    }
}
