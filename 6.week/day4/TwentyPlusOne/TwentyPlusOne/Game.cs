using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        public static Random random = new Random();

        public int GenerateOpponentsScore()
        {
            var score = random.Next(15, 21);
            return score;
        }

        //public void ContinueOrStop(string input)
        //{
        //    Console.WriteLine("Do you want to continue or do you want to stop drawing? Yes or No?");
        //    string input = Console.ReadLine();
        //    if (input == "Yes")
        //    {

        //    }
        //}
    }
}
