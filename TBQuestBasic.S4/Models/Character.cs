using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
    public class Character 
    {
       


        private int _id;
        private string _name;
        private int _locationId;
        





       


        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
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

        

   










    }
}
