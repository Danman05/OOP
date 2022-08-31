using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Blackjack
{
    class Deck
    {
        // ***** Fields *****
        public List<Cards> playerCards = new List<Cards>();
        public List<Cards> dealerCards = new List<Cards>();

        private int playerCardSum = 0;
        private int dealercardSum = 0;
        string cardSymbol = "";
        int cardRank = 0;

        int[,] cards = new int[,] // int, 2 dimensional array for 52 possible cards
        {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        };

        Random rnd = new Random();

        // ***** Properties ******
        public int PlayerCardSum 
        {
            get { return playerCardSum; }
            set { playerCardSum = value; }
        }
        public int DealerCardSum
        {
            get { return dealercardSum; }
            set { dealercardSum = value; }
        }

        // ***** Public Methods ******

        // Method for each card that is picked up
        public void PickUpCard(bool turn)
        {
            bool player = turn;
            if (player == true) // This is were the player gets the cards from
            {
                int symbol = rnd.Next(0, cards.GetLength(0)); // rnd (Random) used to give card symbol
                int number = rnd.Next(0, cards.GetLength(1)); // rnd (Random) used to give card number

                int cardNumber = cards[symbol, number];

                if (cardNumber > 10)
                {
                    cardRank = 10;
                }
                else
                {
                    cardRank = cardNumber;
                }

                switch (symbol)
                {
                    case 0:
                        cardSymbol = "Heart";
                        break;
                    case 1:
                        cardSymbol = "Spade";
                        break;
                    case 2:
                        cardSymbol = "Clover";
                        break;
                    case 3:
                        cardSymbol = "Diamond";
                        break;
                    default:
                        break;
                }
                Cards card = new Cards(cardSymbol, cardRank, cardNumber);
                playerCards.Add(card); // adds card to PlayerCards list
                PlayerCardSum += cardRank;
            }
            else // This is were the dealer gets the cards from
            {
                int symbol = rnd.Next(0, cards.GetLength(0)); // rnd (Random) used to give card symbol
                int number = rnd.Next(0, cards.GetLength(1)); // rnd (Random) used to give card number

                int cardNumber = cards[symbol, number];

                if (cardNumber > 10)
                {
                    cardRank = 10;
                }
                else
                {
                    cardRank = cardNumber;
                }

                switch (symbol)
                {
                    case 0:
                        cardSymbol = "Heart";
                        break;
                    case 1:
                        cardSymbol = "Spade";
                        break;
                    case 2:
                        cardSymbol = "Clover";
                        break;
                    case 3:
                        cardSymbol = "Diamond";
                        break;
                    default:
                        break;
                }
                Cards card = new Cards(cardSymbol, cardRank, cardNumber);
                dealerCards.Add(card); // adds card to dealerCards list
                DealerCardSum += cardRank;
            }

        }
        // Method for displaying the card table
        public void DisplayTableContent()
        {
            Console.Clear();
            Console.WriteLine("Players cards: Sum: " + playerCardSum);
            foreach (Cards card in playerCards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("");
            Console.WriteLine("Computers cards:");
            Console.WriteLine(dealerCards[0]);
        }
    }

}