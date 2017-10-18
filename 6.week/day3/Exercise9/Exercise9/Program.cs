using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = { 's', 't', 'r', 'i', 'n', 'g' };
            var chars = GetLetters(characters);

            Console.WriteLine(string.Join("", chars));
            Console.ReadLine();
        }

        public static IEnumerable<char> GetLetters(char[] input)
        {
            var result =
                from letter in input
                select letter;
            return result;
        }
    }
}
