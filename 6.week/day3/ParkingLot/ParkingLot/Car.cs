using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public enum Types
    {
        Mazda,
        Audi,
        Maserati,
        AlfaRomeo,
        Mercedes,
        Lamborghini,
        FordMustang
    }

    public enum Colors
    {
        Red,
        Black,
        White,
        Blue,
        Grey
    }

    public class Car
    {
        public List<Car> cars = new List<Car>();
        public Random random;

        public Car()
        {
            random = new Random();
        }

        public List<Car> AddCarsToList()
        {
            var carsList = new List<Car>();
            for (int i = 0; i < 256; i++)
            {
                carsList.Add(new Car());
            }
        }
    }
}
