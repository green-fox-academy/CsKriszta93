using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Fox(string name, string type, string color)
        {
            this.Name = name;
            this.Type = type;
            this.Color = color;
        }  
    }
}
