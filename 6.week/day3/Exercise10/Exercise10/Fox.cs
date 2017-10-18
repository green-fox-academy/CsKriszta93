using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Fox
    {
        public string name;
        public string type; 
        public string color;
        public List<Fox> foxes;

        public Fox(string name, string type, string color)
        {
            this.name = name;
            this.type = type;
            this.color = color;
        }

        public List<Fox> AddToList()
        {

        }
    }
}
