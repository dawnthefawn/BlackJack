using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Use .Value and .Face to to return each. 

namespace DeckOfCards
{
    public class Card
    {
        public string suit;
        public string face;
        public int rank;
        public int value;
        private string tag;

        //assign value to card using rank from DeckGenerator Class.
       public int Value(int r)
        {
            rank = r;
            value = 0;
            if (rank < 11)
            {
                switch (rank.ToString())
                {
                    case "1":
                        tag = "A";
                        break;
                    default:
                        tag = r.ToString();
                        break;

                }
                value = rank;
            }
            else if(rank>10)
            {
                value = 10;
                switch(rank.ToString())
                {
                    case "11": tag = "J"; break;
                    case "12": tag = "Q"; break;
                    case "13": tag = "K"; break;
                    
                }
            }
            return value;
        }

        //create the name of the card from the rank in the DeckGenerator class
        //s represents the suit in DeckGenerator that we will pass when we call the card.
        public string Face(int r, string s)
        {
            suit = s;
            face = "";
            switch(s)
            {
                //"♤","◇","♧","❤"
                case "♤":
                    face = tag + " of Spades";
                    break;
                case "◇":
                    face = tag + " of Diamonds";
                    break;
                case "♧":
                    face = tag + " of Clubs";
                    break;
                case "❤":
                    face = tag + " of Hearts";
                    break;      
                default: 
                    break;
            }
            return face;
        }

        //Initialize card, using rank and suit to call the assign functions.


        
    }

   

}
