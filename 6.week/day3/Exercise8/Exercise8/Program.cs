using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string blabla = "jLkdkXdkDkdkOPlS";
            GetUppercaseLetters(blabla);
            Console.ReadLine();
        }

        public static void GetUppercaseLetters(string input)
        {
            var letters = input.Where(x => char.IsUpper(x)).ToList();

            foreach (var letter in letters)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
