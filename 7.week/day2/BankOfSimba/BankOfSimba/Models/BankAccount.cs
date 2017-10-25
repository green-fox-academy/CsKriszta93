using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BankOfSimba.Models.AnimalTypes;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public AnimalType AnimalType { get; set; } 
    }
}
