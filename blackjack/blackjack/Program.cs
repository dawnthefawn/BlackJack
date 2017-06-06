using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class BlackJack
    {
        //last part
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");
            
            Console.WriteLine("Press ESC to stop");
            


            //TEST
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                var generator = new DeckGenerator();
                var shuffler = new Shuffle();
                Card[] deck = shuffler.shuffler(generator.generatedeck(),1);
                foreach (var c in deck)
                {
                    Console.WriteLine(c.face);
                }
                System.Threading.Thread.Sleep(10000000);
            }
        }


      
    }

    
}
