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
        public Card[] generatedeck()
            {
            var deck = new Card[52];
            int index = 0;
                foreach(string suit in new[] { "♤", "◇", "♧", "❤" })
                {
                    for(int rank=1;rank<14;rank++)
                    {

                    //test
                    Console.WriteLine(index);
                    //test

                        deck[index] = new Card();
                        deck[index].Init(rank, suit);

                        index++;
                    }
                }
            
               return deck;
            

                
            }






    }
    
}

