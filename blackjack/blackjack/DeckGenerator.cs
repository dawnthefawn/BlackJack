using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

//Use DeckGenerator.generatedeck() to return a fresh deck of cards.



namespace DeckOfCards
{
    public class DeckGenerator
    {
        ////////////probably garbage: public Card[] newdeck { get; set; }

        //Generate a deck of 52 cards
        public int index;
        public Card[] generatedeck()
            {
                index = 0;
                var deck = new Card[52];
                foreach(string suit in new[] { "♤", "◇", "♧", "❤" })
                {
                    for(int rank=1;rank<14;rank++)
                    {
                        deck[index] = new Card();
                        deck[index].Init(rank, suit);
                    }
                }
            
               return deck;
            

                
            }






    }
    
}

