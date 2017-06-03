using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Card
    {
        public int value { get; set; } //value of card in game
        public string face { get; set; } //the label of the card in game
        public string suit { get; set; } //the suit of the card
        //assign value to card using rank from DeckGenerator Class.
       private int Value(int rank)
        {
            if(rank<11)
            {
                value = rank;
            }
            else if(rank>10)
            {
                value = 10;
            }
            return value;
        }

        //create the name of the card from the rank in the DeckGenerator class
        //s represents the suit in DeckGenerator that we will pass when we call the card.
        private string Face(int rank, string s)
        {
            switch(s)
            {
                case "♤":
                    face = rank.ToString() + " of Spades";
                    break;
                case "◇":
                    face = rank.ToString() + " of Diamonds";
                    break;
                case "♧":
                    face = rank.ToString() + " of Clubs";
                    break;
                case "❤":
                    face = rank.ToString() + " of Hearts";
                    break;
            }
            suit = s;
            return face;
            return suit;
        }

        //Initialize card, using rank and suit to call the assign functions.
        public void main(int r, string s)
        {
            value = Value(r);
            face = Face(r, s);
        }

        
    }
}
