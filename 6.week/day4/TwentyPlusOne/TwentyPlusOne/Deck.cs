using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Deck
    {
        private List<Card> cards = new List<Card>();
        public static Random random = new Random();

        public List<Card> MakeCardList()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 0; rank < 15; rank++)
                {
                    for (int color = 0; color < 2; color++)
                    {
                        cards.Add(new Card((Card.Suit)suit, (Card.Rank)rank, (Card.Color)color));
                    }
                }
            }
            return cards;
        }

        public List<Card> ShuffleDeck()
        {
            var deck = MakeCardList();
            List<Card> shuffle = new List<Card>(deck.OrderBy(card => random.Next()));
            return shuffle;
        }

        public Card PullFirst()
        {
            var firstFromShuffle = ShuffleDeck();
            var randomFirst = firstFromShuffle.First();
            cards.Remove(randomFirst);
            return randomFirst;
        }

        public void PullLast()
        {

        }

        //public Card PullRandom()
        //{
        //    var randomFromShuffle = ShuffleDeck();
        //    var randomCard = random.Next(cards.Count());
        //    cards.RemoveAt(randomCard);
        //}
    }
}
