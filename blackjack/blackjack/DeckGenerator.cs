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
        public int index;
        public Card[] generatedeck()
            {
                index = 0;
                var deck = new Card[52];

                foreach (string suit in new[] { " of Spades", " of Diamonds", " of Clubs", " of Hearts" })
                {

                    for (int rank=1;rank<14;rank++)
                    {
                        Card c = new Card();
                        c.Init(rank, suit);
                        c.value = c.setValue();
                        c.tag = c.setTag();
                        c.face = c.Face();
                        deck[index] = c;
                        index++;
                    }

                }
            
               return deck;
            }
    }
    
}

