using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{

    //This class will manage turns.
    class BlackjackDealer
    {
        public DeckGenerator gen;
        public Shuffle shuffle;
        public Card[] deck;
        public int index;
        public Hand dealerhand;
        public Hand playerhand;
        public Render render;
        public InputHandler input;
        public bool activegame;
        public string win;
        public bool game;
        public int Wins;
        public int Losses;

        public void Initialize()
        {
            game = true;
            activegame = true;
            gen = new DeckGenerator();
            shuffle = new Shuffle();
            dealerhand = new Hand();
            playerhand = new Hand();
            render = new Render();
            input = new InputHandler();

            deck = shuffle.shuffler(gen.generatedeck());
            index = deck.Length;
            FirstTurn();

        }

        public void FirstTurn()
        {
            dealerhand.Init();
            playerhand.Init();
            playerhand.AddCard(DealCard());
            dealerhand.SecretCard(DealCard());
            playerhand.AddCard(DealCard());
            dealerhand.AddCard(DealCard());
            CheckWin();

            input.blackjackTurn(this);

        }

        public void Turn()
        {
            if(activegame == true)
            {
                if (playerhand.stay == false)
                {
                    playerhand.AddCard(DealCard());

                }


                if(dealerhand.secretvalue < 17)
                {
                    dealerhand.AddCard(DealCard());
                }
                else
                {
                    dealerhand.stay = true;
                }
                render.blackjack(dealerhand, playerhand);
                CheckWin();


            }
        }

        public Card DealCard()
        {
            if (index >= 0)
            {
                index--;
                return deck[index];
            }
            else return null;
        }

        public void CheckWin()
        {

            if(playerhand.value > 21)
            {
                activegame = false;
                win = "BUST";
                Losses++;
            }
            else if(dealerhand.secretvalue > 21)
            {
                activegame = false;
                win = "WIN: DEALER BUST";
                Wins++;
            }
            else if(playerhand.stay == true && dealerhand.stay == true)
            {
                if (playerhand.value > dealerhand.secretvalue)
                {
                    activegame = false;
                    win = "WIN: HIGH HAND";
                    Wins++;
                }
                else if (dealerhand.secretvalue == playerhand.value)
                {
                    activegame = false;
                    win = "PUSH";
                }
                else
                {
                    activegame = false;
                    win = "LOSE: LOW HAND";
                    Losses++;
                }
            }
            if (activegame == false)
            {
                render.GameOver(dealerhand, playerhand, win);
                input.GameOver(this);
            }
            else
            {
                render.blackjack(dealerhand, playerhand);
                input.blackjackTurn(this);
            }
            
        }
    }
}
