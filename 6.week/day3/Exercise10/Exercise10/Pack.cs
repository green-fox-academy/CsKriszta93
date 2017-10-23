using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Pack
    {
        public List<Fox> foxes = new List<Fox>();

        public void FindGreenFoxes(List<Fox> input)
        {
            var greenFox = from greenfox in input
                           where greenfox.Color == "green"
                           select greenfox.Name;

            foreach (var Fox in greenFox)
            {
                Console.WriteLine("The fox named {0} is green.", Fox.ToString());
            }
        }

        public void FoxGreenAndPallida(List<Fox> input)
        {
            var greenPallida = from fox in input
                               where fox.Color == "green" || fox.Type == "pallida"
                               select fox.Name;

            foreach (var Fox in greenPallida)
            {
                Console.WriteLine("The fox named {0} is green and pallida.", Fox.ToString());
            }
        }
    }
}
