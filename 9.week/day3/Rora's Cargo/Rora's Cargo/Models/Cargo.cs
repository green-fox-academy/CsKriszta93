using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RorasCargo.Models
{
    public class Cargo
    {
        public long id { get; set; }
        public int caliber { get; set; }
        public bool ready { get; set; }
    }
}
