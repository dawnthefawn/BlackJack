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
        public Card[] hand;
        public int value;

        public void Init()
        {
            handcount = 0;
            value = 0;
            hand = new Card[handcount];
        }

        public int Value()
        {
            return value;
        }

        public void AddCard(Card c)
        {
            handcount++;
            Card[] newhand = new Card[(handcount)];
            if(hand != null)
            {
                foreach(Card c2 in hand)
                {
                    var i = 0;
                    newhand[i] = hand[i];
                }
            }
            
            newhand[handcount] = c;
            var temp = value;
            value += temp + c.value;
           
        }

    }
}
