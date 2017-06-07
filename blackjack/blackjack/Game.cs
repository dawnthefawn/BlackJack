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
            BlackjackDealer dealer = new BlackjackDealer();
            dealer.game = true;
            while (dealer.game == true)
            {
                dealer.Initialize();
            }

        }


      
    }

    
}
