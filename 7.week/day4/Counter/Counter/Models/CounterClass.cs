using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class CounterClass
    {
        public int clicks { get; set; } = 1;

        public int IncreaseCounter()
        {
            return clicks++;
        }
    }
}
