﻿using System;
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
           
                Console.Write(c.face + ", ");
  //              val += c.value;
            }
            Console.WriteLine("Value: " + dealer.Value().ToString());
            Console.WriteLine("=======================================================");




            Console.WriteLine("Your Hand: ");
//            val = 0;
            foreach (Card c in playerhand)
            {
                Console.Write(c.face + ", ");
//                val += c.value;

            }
            Console.WriteLine("Value: " + player.Value().ToString());

        }


    }
}
