using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Render
    {
        public void blackjack(Hand dealer, Hand player)
        {
            var dealerhand = dealer.hand;
            var playerhand = player.hand;
//            int val = 0;
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("Dealer Shows: ");



            foreach(Card c in dealerhand)
            {           
                Console.Write(c.face + " ");
            }
            Console.WriteLine("\n" + "Value: " + dealer.value + "\n" + "=======================================================");


            Console.WriteLine("Your Hand: ");

            foreach (Card c in playerhand)
            {
                Console.Write(c.face + " ");
            }
            Console.WriteLine("Value: " + player.value.ToString());

        }

        public void GameOver(Hand dealer, Hand player, string win)
        {
            var dealerhand = dealer.hand;
            var playerhand = player.hand;
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("Dealer Shows: ");


            foreach (Card c in dealerhand)
            {

                Console.Write(c.face + " ");

            }
            Console.WriteLine(dealer.secretcard.face);
            Console.WriteLine("Value: " + dealer.secretvalue.ToString());
            Console.WriteLine("=======================================================");
            Console.WriteLine("Your Hand: ");

            foreach (Card c in playerhand)
            {
                Console.Write(c.face + ", ");
                Console.WriteLine();
            }

            Console.WriteLine("Value: " + player.value.ToString());
            Console.WriteLine(win.ToString());
        }


    }
}
