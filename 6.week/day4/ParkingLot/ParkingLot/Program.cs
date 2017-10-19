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
            parkingLot.StateOfParkingLot();

            var carList = parkingLot.AddCarsToList();

            var sameColor = carList.GroupBy(car => car.carColors).ToDictionary(car => car.Key, car => car.Count());
            foreach (var car in sameColor)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            var sameType = carList.GroupBy(car => car.carTypes).ToDictionary(car => car.Key, car => car.Count());
            foreach (var car in sameType)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }
}
