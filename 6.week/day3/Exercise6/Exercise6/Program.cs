using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string blabla = "sbfgsjfkjkfjkfsghfb";

            var freq =
                from i in blabla
                group i by i into j
                select j;

            foreach (var letter in freq)
            {
                Console.WriteLine("The letter " + letter.Key + " appears " + letter.Count() + " times." );
            }

            Console.ReadLine();
        }
    }
}
