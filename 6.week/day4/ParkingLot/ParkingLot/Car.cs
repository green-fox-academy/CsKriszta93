using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car
    {
        public Type carTypes { get; set; }
        public Color carColors { get; set; }
        public static Random random = new Random();

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
            this.carTypes = carType;
            this.carColors = carColor;
        }

        public static Type GenerateType()
        {
            var enumValues = Enum.GetValues(typeof(Type));
            var randomValue = (Type)enumValues.GetValue(random.Next(enumValues.Length));
            return randomValue;
        }

        public static Color GenerateColor()
        {
            var enumValues = Enum.GetValues(typeof(Color));
            var randomValue = (Color)enumValues.GetValue(random.Next(enumValues.Length));
            return randomValue;
        }

        public override string ToString()
        {
            return $"{carTypes}, {carColors}";
        }
    }
}
