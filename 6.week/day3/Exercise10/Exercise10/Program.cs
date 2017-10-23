using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        public static List<Fox> foxes;

        static void Main(string[] args)
        {
            var fox = new Fox("Vuk", "pallida", "red");
            foxes.Add(fox);
            var fox2 = new Fox("Karak", "sarki", "white");
            foxes.Add(fox2);
            var fox3 = new Fox("Bobby", "ezust", "grey");
            foxes.Add(fox3);
            var fox4 = new Fox("Teddy", "pallida", "green");
            foxes.Add(fox4);
            var fox5 = new Fox("Lauren", "pallida", "green");
            foxes.Add(fox5);

         
        }
    }
}
