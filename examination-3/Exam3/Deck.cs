using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exam3
{
    public class Deck
    {
        public List<Card> deck;

        public List<Card> throwPile = new List<Card>();
        public Deck()
        {
            createDeck();
        }
        public void createDeck()
        {
            deck = new List<Card>();
            string[] cardSuits = { "♥", "♦", "♣", "♠" };
            int[] cardNumber = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            
            for(int cs = 0; cs < cardSuits.Length; cs++)
            {
                for(int cn = 0; cn < cardNumber.Length; cn++)
                {
                    deck.Add(new Card(cardSuits[cs], cardNumber[cn]));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for ( int i = deck.Count - 1; i > 0; i-- )
            {
                int rndInd = rand.Next(deck.Count - 1);
                Card swap = deck[i];
                deck[i] = deck[rndInd];
                deck[rndInd] = swap;
            }
        }

        public void ShowCards()
        {
            foreach( Card c in deck)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public Card DealCard()
        {
            Card activeCards = deck[0];
            deck.RemoveAt(0);
            return activeCards;
        }


        public void remixCards()
        {
            if (deck.Count <= 1)
            {
                deck = throwPile;
                throwPile = new List<Card>();
                Shuffle();
            }
        }
    }
}