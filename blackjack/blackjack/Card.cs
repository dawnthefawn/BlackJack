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
        public string tag;

        public void Init(int r, string s)
        {
            rank = r;
            suit = s;
            value = 0;
            tag = "";
            face = "";
        }

        //assign value to card using rank from DeckGenerator Class.
       public string setTag()
        {
            string t = "";
                    switch (rank.ToString())
                    {
                        case "1": t = "A"; break;
                        case "11": t = "J"; break;
                        case "12": t = "Q"; break;
                        case "13": t = "K"; break;
                        default:  t = rank.ToString(); break;

                    }
            return t ;
                }
        

       public int setValue()
        {
        if(rank > 9)
            { return 10; }
        else { return rank; }
        }

        //create the name of the card from the rank in the DeckGenerator class
        //s represents the suit in DeckGenerator that we will pass when we call the card.
        public string Face() => tag + suit;

        //Initialize card, using rank and suit to call the assign functions.


        
    }

   

}
