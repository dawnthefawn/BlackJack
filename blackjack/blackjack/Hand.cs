using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Hand
    {
//        public int handcount;
        public List<Card> hand;
        public int value;
        public bool stay;
        public Card secretcard;
        public int secretvalue;

        public void Init()
        {
            stay = false;
//            handcount = 0;
            value = 0;

            hand = new List<Card>();
        }


        public void AddCard(Card c)
        {
//            handcount++;
            hand.Add(c);
            value += value + c.value;
            secretvalue += secretvalue + c.value;
        }

        public void SecretCard(Card c)
        {
 //           handcount++;
            secretcard = c;
            secretvalue += secretcard.value;
        }

    }
}
