using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    //Shuffle the deck of cards by setting the deck = to Shuffle.shuffler(deck being shuffled, number of decks in play.)

    public class Shuffle
    {
        private static Random random = new Random();
        //call using number of decks, if you want to play with 10 decks for some reason :D
        public Card[] shuffler(Card[] deck)
        {
            int n = deck.Length;
            for(int i = n-1; i > 0; i--)
            {
                int index = random.Next(i);
                Card card = deck[index];
                deck[index] = deck[i];
                deck[i] = card;
            }

            return deck;


        }


    }
}
