using System;

namespace Exam3
{
    public class Card
    {
        private int cardValue;
        private string cardSuit;
        public int Value 
        {
            get
            {
                return cardValue;
            }
        }
        public string card
        {
            get 
            {
                if(cardValue == 14)
                {
                    return "A";
                }
                else if (cardValue == 13)
                {
                    return "K";
                }
                else if (cardValue == 12)
                {
                    return "Q";
                }
                else if (cardValue == 11)
                {
                    return "J";
                }
                else 
                {
                    return cardValue.ToString();
                }
            }
        }

        public Card(string cS, int cV)
        {
            cardSuit = cS;
            cardValue = cV;
        }
        public override string ToString()
        {
            if( cardValue == 11 )
            {
                return "J" + cardSuit;
            }
            if ( cardValue == 12)
            {
                return "Q" + cardSuit;
            }
            if (cardValue == 13)
            {
                return "K" + cardSuit;
            }
            if (cardValue == 14)
            {
                return "A" + cardSuit;
            }
            return cardValue + cardSuit;
        }

    }
}