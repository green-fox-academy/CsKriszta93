using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new ParkingLotClass();
            var cars = parkingLot.AddCarsToList();

            foreach (var Car in cars)
            {
                Console.WriteLine(Car);
            }
        }
    }
}
