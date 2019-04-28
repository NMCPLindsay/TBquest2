using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models.GameObjects
{
    public class GameObjectQuantity
    {
        public GameObject GameObject { get; set; }
        public int Quantity { get; set; }

        public GameObjectQuantity()
        {

        }

        public GameObjectQuantity(GameObject gameObject, int quantity)
        {
            GameObject = gameObject;
            Quantity = quantity;
        }


    }
}
