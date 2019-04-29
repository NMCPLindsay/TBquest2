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
        private bool _isPlanet;
        private bool _isLocation;
        private bool _isBuilding;
                                    
        #endregion

        #region PROPERTIES

        public bool IsBuilding
        {
            get { return _isBuilding; }
            set { _isBuilding = value; }
        }

        public bool IsLocation
        {
            get { return _isLocation; }
            set { _isLocation = value; }
        }

        public bool IsPlanet
        {
            get { return _isPlanet; }
            set { _isPlanet = value; }
        }

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
            _gameObjects = new ObservableCollection<GameObjectQuantity>(); 
        }

        #endregion

        #region METHODS
        public override string ToString()
        {
            return _name;
        }

        public void AddGameObjectQuantityToLocation(GameObjectQuantity selectedGameItemQuantity)
        {
            GameObjectQuantity gameObjectQuantity = _gameObjects.FirstOrDefault(i => i.GameObject.Id == selectedGameItemQuantity.GameObject.Id);

            if (gameObjectQuantity == null)
            {
                GameObjectQuantity newGamObjectQuantity = new GameObjectQuantity();
                newGamObjectQuantity.GameObject = selectedGameItemQuantity.GameObject;
                newGamObjectQuantity.Quantity = 1;

                _gameObjects.Add(newGamObjectQuantity);
            }
            else
            {
                gameObjectQuantity.Quantity++;
            }
            UpdateLocationGameObjects();
        }

        public void UpdateLocationGameObjects()
        {
            ObservableCollection<GameObjectQuantity> updatedLocationObjects = new ObservableCollection<GameObjectQuantity>();

            foreach (GameObjectQuantity gameObjectQuantity in _gameObjects)
            {
                updatedLocationObjects.Add(gameObjectQuantity);
            }
            GameObjects.Clear();
            foreach (GameObjectQuantity gameObjectQuantity in updatedLocationObjects)
            {
                GameObjects.Add(gameObjectQuantity);
            }
        }

        public void RemoveGameItemQuantityFromLocation(GameObjectQuantity selectedGameObjectQuantity)
        {
            GameObjectQuantity gameObjectQuantity = _gameObjects.FirstOrDefault(i => i.GameObject.Id == selectedGameObjectQuantity.GameObject.Id);

            if (gameObjectQuantity != null)
            {
                if (selectedGameObjectQuantity.Quantity ==1)
                {
                    _gameObjects.Remove(gameObjectQuantity);
                }
                else
                {
                    gameObjectQuantity.Quantity--;
                }
            }
            UpdateLocationGameObjects();
        }
        #endregion

    }
}
