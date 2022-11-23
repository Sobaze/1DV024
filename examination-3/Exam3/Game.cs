using System;

namespace Exam3
{
    public class Game
    {
        Deck gameDeck = new Deck();
    
        Hand[] players = new Hand[21];
        Hand dealer = new Hand();

        public void Play()
        {
            gameDeck.Shuffle();
            for(int i = 0; i < players.Length; i++)
            {
                players[i] = new Hand();

            }
            
            GivePlayerCards();

            Random rnd = new Random();
            for (int i = 0; i < players.Length; i++)
            {
                gameDeck.remixCards();
            int count = players[i].DisplayHand().Count;
            players[i].HitCard(gameDeck);
                while(players[i].scoreCounter() < rnd.Next(12,20) && count < 5)
                {
                    gameDeck.remixCards();
                    players[i].HitCard(gameDeck);
                    gameDeck.remixCards();
                }
                if(players[i].scoreCounter() < 21 && players[i].DisplayHand().Count < 5)
                {
                DealerTakeCards();

                }

                if(players[i].scoreCounter() > 21)
                {
                    Console.Write("Player " + (i + 1) + ": " );
                    players[i].RevealHand();
                    Console.WriteLine( "Score: " + "(" + players[i].scoreCounter() + ")" + " BUSTED" );
                    Console.Write("Dealer: - " + "\n");
                    Console.WriteLine("Dealer Wins!" + "\n");
                }

                else if( players[i].scoreCounter() < 21 && players[i].DisplayHand().Count == 5 )
                {
                    Console.Write("Player " + (i + 1) + ": ");
                    players[i].RevealHand();
                    Console.WriteLine( "Score: " + "(" +  players[i].scoreCounter() + ")" );
                    Console.Write( "Dealer: - " + "\n");
                    Console.WriteLine("Player Wins!" + "\n");
                }
                else if( players[i].scoreCounter() < 21 && players[i].scoreCounter() > dealer.scoreCounter())
                {
                    Console.Write("Player " + (i + 1 ) + ": ");
                    players[i].RevealHand();
                    Console.WriteLine("Score: " + "(" + players[i].scoreCounter() + ")" );
                    Console.Write("Dealer: ");
                    dealer.RevealHand();
                    Console.WriteLine("Score: " + "(" + dealer.scoreCounter() + ")");
                    Console.WriteLine("Player Wins!" + "\n");
                }
                else if(players[i].scoreCounter() < 21 && dealer.scoreCounter() > 21)
                {
                    Console.Write("Player " + (i + 1 ) + ": ");
                    players[i].RevealHand();
                    Console.WriteLine("Score: " + "(" + players[i].scoreCounter() + ")" );
                    Console.Write("Dealer: ");
                    dealer.RevealHand();
                    Console.WriteLine("Score: " + "(" + dealer.scoreCounter() + ")" + " BUSTED");
                    Console.WriteLine("Player Wins!" + "\n"); 
                }
                 else if(players[i].scoreCounter() < 21 && players[i].scoreCounter() == dealer.scoreCounter())
                {
                     Console.Write("Player " + (i + 1 ) + ": ");
                    players[i].RevealHand();
                    Console.WriteLine("Score: " + "(" + players[i].scoreCounter() + ")" );
                    Console.Write("Dealer: ");
                    dealer.RevealHand();
                    Console.WriteLine("Score: " + "(" + dealer.scoreCounter() + ")");
                    Console.WriteLine("Dealer Wins!" + "\n");
                }
                else if( players[i].scoreCounter() == 21 )
                {
                     Console.Write("Player " + (i + 1 ) + ": ");
                    players[i].RevealHand();
                    Console.WriteLine("Score: " + "(" + players[i].scoreCounter() + ")" );
                    Console.Write("Dealer: - " + "\n");
                    Console.WriteLine("Player Wins!" + "\n");
                }
                else
                {
                     Console.Write("Player " + (i +1 ) + ": ");
                    players[i].RevealHand();
                    Console.WriteLine("Score: " + "(" + players[i].scoreCounter() + ")" );
                    Console.Write("Dealer: ");
                    dealer.RevealHand();
                    Console.WriteLine("Score: " + "(" + dealer.scoreCounter() + ")");
                    Console.WriteLine("Dealer Wins!" + "\n");
                }
                
                foreach(Card card in players[i].hand)
                {
                    gameDeck.throwPile.Add(card);
                }
                players[i].ThrowHands();
                foreach(Card card in dealer.hand)
                {
                    gameDeck.throwPile.Add(card);
                }
                Console.Write(gameDeck.deck.Count + "normal deck" + "\n");
                Console.Write(gameDeck.throwPile.Count + "thrown cards" + "\n");
                
                dealer.ThrowHands();
            }
        }

        public void GivePlayerCards()
        {
            // Random rnd = new Random();
            foreach(Hand p in players)
            {
                int count = p.DisplayHand().Count;
                p.GetCard(gameDeck);
                // p.HitCard(gameDeck);
                // while(p.scoreCounter() < rnd.Next(12,20) && count < 5)
                // {
                //     p.HitCard(gameDeck);
                // }
                
            }
        }

        public void DealerTakeCards()
        {
            gameDeck.remixCards();
            Random rnd = new Random();
            int count = dealer.DisplayHand().Count;
            while(dealer.scoreCounter() < rnd.Next(12,20) && count < 5)
            {
                dealer.HitCard(gameDeck);
            }
        }
    }
}