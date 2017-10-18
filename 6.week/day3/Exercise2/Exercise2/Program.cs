using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var oddList = GetOddNumbers(n);
            double result = oddList.Average();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static List<int> GetOddNumbers(int[] input)
        {
            var oddList = input.Where(x => x % 2 != 0).ToList();
            return oddList;
        } 
    }
}
