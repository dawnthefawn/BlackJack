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
            if (dealer.playerhand.stay == false)
            {
                Console.WriteLine("What would you like to do? \n");
                Console.WriteLine("(H)it, (S)tay, (T)able flip: ");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();
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
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        blackjackTurn(dealer);
                        break;

                }
            }
            else
            {
                dealer.Turn();
            }


           
        }


        public void GameOver(BlackjackDealer dealer)
        {
            Console.WriteLine(dealer.Wins.ToString() + " wins so far." + "\n" + dealer.Losses.ToString() + " losses so far.");
            Console.WriteLine("Would you like to play again? Y/N");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch(input)
            {
                case 'y':
                    dealer.Initialize();
                    break;
                case 'n':
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid input, try again");
                    GameOver(dealer);
                    break;

            }

        }
    }
}
