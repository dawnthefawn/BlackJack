using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace blackjack
{
    public class DeckGenerator
    {
        public Card[] deck;
        //Generate a deck of 52 cards
        public void main()
            {
            deck = new Card[52];
            int index = 1;
                foreach(string suit in new[] { "♤", "◇", "♧", "❤" })
            {
                for(int rank=1;rank<14;rank++)
                {
                    deck[index] = new Card();
                    deck[index].Value(rank);
                    deck[index].Face(rank, suit);
                    index++;


                }
            }
            }
    }
    
}

