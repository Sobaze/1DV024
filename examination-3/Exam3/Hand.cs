using System;
using System.Collections.Generic;

namespace Exam3
{
    public class Hand
    {
        public List<Card> hand = new List<Card>();
        public List<Card> throwCards = new List<Card>();

        public void GetCard(Deck deck)
        {
            hand.Add(deck.DealCard());
        }
        public void HitCard(Deck deck)
        {
            hand.Add(deck.DealCard());
        }

        public List<Card> DisplayHand()
        {
            return hand;
        }

        public void RevealHand()
        {
            foreach(Card c in hand)
            {
                Console.Write(c.ToString() + " ");
            }
        }


        public int scoreCounter()
        {
            int score = 0;
            int ace = 0;
            foreach( Card c in hand )
            {
                if(c.Value == 14)
                {
                    ace += 1;
                }
                score += c.Value;
            }
            while(score > 21 && ace > 0)
            {
                score -= 13;
                ace -= 1;
            }
            return score;
        }

        public void ThrowHands()
        {
            hand.Clear();
        }
    }
}