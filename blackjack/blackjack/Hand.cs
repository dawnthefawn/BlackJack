using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Hand
    {
        public int handcount;
        public List<Card> hand;
        public int value;

        public void Init()
        {
            handcount = 0;
            value = 0;
            hand = new List<Card>();
        }

        public int Value(Card c)
        {
            return value + c.value;
        }

        public void AddCard(Card c)
        {
            handcount++;
            hand.Add(c);
            value = Value(c);
        }

    }
}
