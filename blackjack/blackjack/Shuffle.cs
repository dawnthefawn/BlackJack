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
        public Card[] shuffler(Card[] unshuffled, int numberofdecks)
        {
            int index = numberofdecks * 52;
            Random r = new Random();
            //            while(index>1)
            //                {
            //               var n = r.Next(index);
            //               shuffled[shuffleindex] = unshuffled[n];
            //             Array.Sort
            //           shuffleindex++;
            //         index--;
            //       }
            return unshuffled.OrderBy(x => r.Next(0, index)).ToArray();
        }

    }
}
