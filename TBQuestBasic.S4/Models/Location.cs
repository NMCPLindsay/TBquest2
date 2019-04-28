using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TBQuestBasic.Models.GameObjects;
using TBQuestBasic.Models.NPC;
using TBQuestBasic.Models.Interface;

namespace TBQuestBasic.Models 
{
    public class Location : ObservableObject
    {
        #region FIELDS
        private int _id;
        private string _name;
        private string _description;
        private ObservableCollection<GameObjectQuantity> _gameObjects;
        private bool _canHaveShip;
        private ObservableCollection<NPC.NPC> _npcs;
        private Uri _locationImage;




        #endregion

        #region PROPERTIES

        public Uri LocationImage
        {
            get { return _locationImage; }
            set { _locationImage = value; }
        }

        public ObservableCollection<NPC.NPC> NPCS
        {
            get { return _npcs; }
            set { _npcs = value; }
        }   

        public bool CanHaveShip
        {
            get { return _canHaveShip; }
            set { _canHaveShip = value; }
        }


        public ObservableCollection<GameObjectQuantity> GameObjects
        {
            get { return _gameObjects; }
            set { _gameObjects = value; }
        }
               

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Location()
        {
            
        }

        #endregion

        #region METHODS
        public override string ToString()
        {
            return _name;
        }

        #endregion
        
    }
}
