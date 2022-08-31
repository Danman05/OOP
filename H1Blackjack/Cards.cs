using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Blackjack
{
    public struct Cards
    {
        // ***** Fields *****
        private string cardSymbol;
        private int cardRank;
        private int cardNumber;

        // ***** Constants *****
     
        // ***** Constructor *****
        public Cards(string cardSymbol, int cardRank, int cardNumber)
        {
            this.cardSymbol = cardSymbol;
            this.cardRank = cardRank;
            this.cardNumber = cardNumber;
        }
        // ***** Properties *****
        public string CardSymbol 
        {
            get { return cardSymbol; }
            set { cardSymbol = value; }
        }
        public int CardRank
        {
            get { return cardRank; }
            set { cardRank = value; }
        }
        public int CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        // ***** Public Methods ******
        public override string ToString()
        {
            // If number is greater than 10 then run
            if (CardNumber > 10)
            {
                string cardWithPicture = ""; // empty string to use in switch

                switch (CardNumber) // switch starts when if statements condition is met
                {                   // Gives the card the picture name, depending on its number
                    case 11:
                        cardWithPicture = "Jack";
                        break;
                    case 12:
                        cardWithPicture = "Queen";
                        break;
                    case 13:
                        cardWithPicture = "King";
                        break;
                    default:
                        break;
                }
                return CardSymbol + ":" + cardWithPicture;
            }
            else
            {
                return CardSymbol + ":" + CardNumber;
            }
        }
    }

}
