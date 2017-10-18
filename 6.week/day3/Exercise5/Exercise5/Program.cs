using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var freq =
                from number in n
                group number by number into x
                select x;

            foreach (var num in freq)
            {
                Console.WriteLine("Number " + num.Key + " appears " + num.Count()+ " times" );
            }

            Console.ReadLine();
        }
    }
}
