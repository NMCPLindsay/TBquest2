using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.Models;

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

        public static List<string> InitialMessages()
        {
            return new List<string>
            {
                "Hello, You have been selected to search and apprehend or eliminate contracts from clients of Bounty Force.",
                "Please see the Mission Briefer for your mission and good luck. Do not disappoint."


            };


        }


        








    }
}
