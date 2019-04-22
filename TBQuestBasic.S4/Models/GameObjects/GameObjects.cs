using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.DataLayer;

namespace TBQuestBasic.Models
{
    public class GameObjects
    {
        private int _id;
        private string _name;
        private string _description;
        private string _useMessage;
      





        public string UseMessage
        {
            get { return _useMessage; }
            set { _useMessage = value; }
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




        public string Information
        {
            get
            {
                return InformationString();
            }
        }



     


        public GameObjects(int id, string name, string description, string useMessage="")
        {
            Id = id;
            Name = name;
            Description = description;
            
            UseMessage = useMessage;
        }






        public virtual string InformationString()
        {
            return $"{Name}: {Description}";
        }

    }
}
