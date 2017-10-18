using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var result =
                from city in cities
                where city[0] == 'A' && city[city.Length - 1] == 'I' 
                select city;

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

