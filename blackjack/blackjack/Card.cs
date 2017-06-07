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
        private static string tag;

        public void Init(int r, string s)
        {
            rank = r;
            suit = s;
            value = setValue(r);
            setTag(r);



        
        
        }

        //assign value to card using rank from DeckGenerator Class.
       private void setTag(int r)
        {
                    switch (r.ToString())
                    {
                        case "1": tag = "A"; break;
                        case "11": tag = "J"; break;
                        case "12": tag = "Q"; break;
                        case "13": tag = "K"; break;
                        default:  tag = r.ToString(); break;

                    }
            face = Face(tag, suit);
                }
        

       public int setValue(int r)
        {
        if(r > 9)
            { return 10; }
        else { return r; }
        }

    //create the name of the card from the rank in the DeckGenerator class
    //s represents the suit in DeckGenerator that we will pass when we call the card.
    public string Face(string t, string s)
        {
            string face = t + s;
            return face;
        }

        //Initialize card, using rank and suit to call the assign functions.


        
    }

   

}
