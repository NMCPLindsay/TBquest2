using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TBQuestBasic.Models.NPC
{
    public class NPC
    {
        #region FIELDS
        private int _id;
        private string _name;
        private ObservableCollection<GameObjects.GameObjectQuantity> _npcGameObjects;
        #endregion

        #region PROPERTIES
        public ObservableCollection<GameObjects.GameObjectQuantity> NPCGameObjects
        {
            get { return _npcGameObjects; }
            set { _npcGameObjects = value; }
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
        public NPC()
        {

        }
        #endregion

        #region METHODS

        #endregion
    }
}
