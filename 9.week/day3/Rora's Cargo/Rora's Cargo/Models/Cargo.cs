using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RorasCargo.Models
{
    public class Cargo
    {
        public long Id { get; set; }
        public int Caliber { get; set; }
        public bool Ready { get; set; }
    }
}
