using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestBasic.Models
{
    public class Location
    {
        private int _id;
        private string _name;
        private string _description;
        private bool _isAccessable;

        public bool IsAccessable
        {
            get { return _isAccessable; }
            set { _isAccessable = value; }
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





    }
}
