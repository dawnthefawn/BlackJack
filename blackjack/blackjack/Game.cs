using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Game
    {

        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.UTF8;
            BlackjackDealer dealer = new BlackjackDealer();
            dealer.game = true;
            dealer.Initialize();
            

        }


      
    }

    
}
