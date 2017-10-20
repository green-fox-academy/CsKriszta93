using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    public class Card
    {
        public Color cardColor { get; set; }
        public Suit cardSuit { get; set; }
        public Rank cardRank { get; set; }
        public static Random random = new Random();

        public Card(Suit suit, Rank rank, Color color)
        {
            this.cardSuit = suit;
            this.cardRank = rank;
            this.cardColor = color;
        }

        public enum Color
        {
            red,
            black
        }

        public enum Suit
        {
            clubs,
            diamonds,
            hearts,
            spades            
        }

        public enum Rank
        {
            two = 2,
            three =3, 
            four = 4, 
            five = 5, 
            six = 6, 
            seven = 7, 
            eight = 8, 
            nine = 9, 
            ten = 10,
            J = 11,
            Q = 12,
            K = 13,
            A = 14
        }

        //public static Color GenerateColor()
        //{
        //    var enumValues = Enum.GetValues(typeof(Color));
        //    var randomValue = (Color)enumValues.GetValue(random.Next(enumValues.Length));
        //    return randomValue;
        //}

        //public static Suit GenerateSuit()
        //{
        //    var enumValues = Enum.GetValues(typeof(Suit));
        //    var randomValue = (Suit)enumValues.GetValue(random.Next(enumValues.Length));
        //    return randomValue;
        //}

        //public static Rank GenerateRank()
        //{
        //    var enumValues = Enum.GetValues(typeof(Rank));
        //    var randomValue = (Rank)enumValues.GetValue(random.Next(enumValues.Length));
        //    return randomValue;
        //}

        public override string ToString()
        {
            return $"{cardSuit}, {cardRank}, {cardColor}";
        }
    }
}
