using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieTable.Models
{
    public class Food
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Calorie { get; set; }
    }
}
