using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program 
    {
        static void Main(string[] args)
        {
            var pack = new Pack();

            var fox = new Fox("Vuk", "pallida", "red");
            pack.foxes.Add(fox);
            var fox2 = new Fox("Karak", "sarki", "white");
            pack.foxes.Add(fox2);
            var fox3 = new Fox("Bobby", "ezust", "grey");
            pack.foxes.Add(fox3);
            var fox4 = new Fox("Teddy", "pallida", "green");
            pack.foxes.Add(fox4);
            var fox5 = new Fox("Lauren", "pallida", "green");
            pack.foxes.Add(fox5);

            pack.FindGreenFoxes(pack.foxes);
            pack.FoxGreenAndPallida(pack.foxes);
            Console.ReadLine();
        }
    }
}
