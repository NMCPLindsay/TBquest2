using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
    public class GameObjectQuantity
    {
        public GameObjects GameObject { get; set; }
        public int Quantity { get; set; }

        public GameObjectQuantity()
        {

        }

        public GameObjectQuantity(GameObjects gameObject, int quantity)
        {
            GameObject = gameObject;
            Quantity = quantity;
        }


    }
}
