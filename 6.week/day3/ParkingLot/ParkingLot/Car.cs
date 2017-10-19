using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car
    {
        public Type CarTypes { get; set; }
        public Color CarColors { get; set; }
        public Random random = new Random();

        public enum Type
        {
            Mazda,
            Audi,
            Maserati,
            AlfaRomeo,
            Mercedes,
            Lamborghini,
            FordMustang
        }

        public enum Color
        {
            Red,
            Black,
            White,
            Blue,
            Grey
        }

        public Car(Type carType, Color carColor)
        {
            this.CarTypes = carType;
            this.CarColors = carColor;
        }
    }
}
