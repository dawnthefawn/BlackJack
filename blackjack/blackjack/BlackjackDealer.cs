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

        public void Initialize()
        {
            gen = new DeckGenerator();
            shuffle = new Shuffle();
            dealerhand = new Hand();
            playerhand = new Hand();
            render = new Render();

            deck = shuffle.shuffler(gen.generatedeck());
            index = deck.Length - 1;
            FirstTurn();
            render.blackjack(dealerhand, playerhand);
            System.Threading.Thread.Sleep(10000000);

        }

        public void FirstTurn()
        {
            dealerhand.Init();
            playerhand.Init();
            playerhand.AddCard(DealCard());
            dealerhand.AddCard(DealCard());
            playerhand.AddCard(DealCard());
            
        }

        public Card DealCard()
        {
            var card = deck[index];
            index--;
            return card;
        }
    }
}
