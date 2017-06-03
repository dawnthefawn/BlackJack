using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class Card
    {
        //assign value to card using rank from DeckGenerator Class.
       public int Value(int rank)
        {
            var value = 0;
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
        public string Face(int rank, string s)
        {
            var face = "";
            switch(s)
            {
                //"♤","◇","♧","❤"
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
                default: 
                    break;
            }
            return face;
        }

        //Initialize card, using rank and suit to call the assign functions.


        
    }

   

}
