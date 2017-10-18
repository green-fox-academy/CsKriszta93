using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            Console.WriteLine(string.Join(", ", GetEvenNumbers(n)));
            GetEvenLambda(n); 
            Console.ReadLine();       
        }

        public static IEnumerable<int> GetEvenNumbers(int[] input)
        {
            var evenArr =
                (from number in input
                where number % 2 == 0
                select number);
            return evenArr;
        }

        public static void GetEvenLambda(int[] input)
        {
            var evenWithLambda = input.Where(x => x % 2 == 0).ToList();

            foreach (int i in evenWithLambda)
            {
                Console.WriteLine(i);
            }
        }
    }
}
