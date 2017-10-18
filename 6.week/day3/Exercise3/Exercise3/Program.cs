using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            Console.WriteLine(string.Join(" , ", GetPositiveNumbers(n)));
            Console.ReadLine();
        }

        public static IEnumerable<int> GetPositiveNumbers(int[] input)
        {
            var oddNums =
                from number in input
                where number > 0
                select number * number;
            return oddNums;
        }   
    }
}
