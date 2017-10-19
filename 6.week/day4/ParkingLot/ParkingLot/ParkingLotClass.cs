using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLotClass
    {
        public List<Car> cars = new List<Car>();

        public List<Car> AddCarsToList()
        {
            var carsList = new List<Car>();

            for (int i = 0; i < 256; i++)
            {
                carsList.Add(new Car(Car.GenerateType(), Car.GenerateColor()));
            }
            return carsList;
        }

        public void StateOfParkingLot()
        {
            var cars = AddCarsToList();
            foreach (var Car in cars)
            {
                Console.WriteLine("Color: {0}, Type: {1}", Car.GenerateColor().ToString(), Car.GenerateType().ToString());
            }
        }
    }
}
