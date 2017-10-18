using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            Console.WriteLine(string.Join(", ", SquareMoreThan20(n)));
            Console.ReadLine();
        }

        public static IEnumerable<int> SquareMoreThan20(int[] input)
        {
            var square =
                from number in input
                let sq = number * number
                where sq > 20
                select sq;
            return square;
        }
    }
}
