using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class InputHandler
    {
        public void blackjackTurn(BlackjackDealer dealer)
        {
            Console.WriteLine("What would you like to do? \n");
            Console.WriteLine("(H)it, (S)tay, (T)able flip: ");
            char input = Console.ReadKey().KeyChar;
            switch (input)
            {

                case 'h':
                    dealer.Turn();
                    break;
                case 's':
                    dealer.playerhand.stay = true;
                    dealer.Turn();
                    break;
                case 't':
                    dealer.game = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again");
                    blackjackTurn(dealer);
                    break;

            }



           
        }


        public void GameOver(BlackjackDealer dealer)
        {

            Console.WriteLine("Would you like to play again? Y/N");
            Console.WriteLine(dealer.Wins.ToString() + " wins so far.");
            char input = Console.ReadKey().KeyChar;
            switch(input)
            {
                case 'y':
                    dealer.Initialize();
                    break;
                case 'n':
                    dealer.game = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again");
                    GameOver(dealer);
                    break;

            }

        }
    }
}
