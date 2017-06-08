using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Hand
    {
        public List<Card> hand;
        public int value;
        public bool stay;
        public Card secretcard;
        public int secretvalue;

        public void Init()
        {
            stay = false;
            value = 0;

            hand = new List<Card>();
        }


        public void AddCard(Card c)
        {
            hand.Add(c);
            value += c.value;
            secretvalue += c.value;
        }

        public void SecretCard(Card c)
        {
            secretcard = c;
            secretvalue += secretcard.value;
        }

    }
}
