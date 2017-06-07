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

        //call using number of decks, if you want to play with 10 decks for some reason :D
        public Card[] shuffler(Card[] unshuffled)
        {
            int index = unshuffled.Length;
            Random r = new Random();
            return unshuffled.OrderBy(x => r.Next(0, index)).ToArray();
        }

    }
}
