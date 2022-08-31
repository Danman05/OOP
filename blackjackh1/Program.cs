using System;

namespace blackjackh1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true; // Bool to keep do while loop running until its changed to false
            do
            {
                int[] playerCards = new int[3]; // int array for player with lenght of 3, to hold 3 cards
                int playerCardValue = 0; // Sets default card sum to 0
                int[] dealerCards = new int[3]; // int array for computer with lenght of 3, to hold 3 cards
                int dealerCardValue = 0; // Sets default card sum to 0

                Hand hand = new Hand(); // Makes a new object from Hand class

                // *********************************************Players Turn***************************************************
                Console.WriteLine("Player cards: ");

                for (int i = 0; i < playerCards.Length; i++) // Loops run the amount of lenght in playerCards
                {
                    playerCards[i] = hand.DrawCards(); // Uses method from the Hand class and saves the number in an array
                    Console.WriteLine("Your card: {0}", playerCards[i]);

                    playerCardValue += playerCards[i];
                    if (playerCardValue > 21)
                    {
                        Console.WriteLine("You got over 21");
                        isRunning = false;
                        
                    }
                }
                Console.WriteLine("You got {0}\n",playerCardValue); // Displays total sum of cards

                // *********************************************Dealers Turn***************************************************
                Console.WriteLine("Dealers cards: ");
                for (int i = 0; i < dealerCards.Length; i++)
                {
                    dealerCards[i] = hand.DrawCards(); // Uses method from the Hand class and saves the number in an array
                    Console.WriteLine("Dealers card: {0}", dealerCards[i]);

                    dealerCardValue += dealerCards[i]; 
                    if (dealerCardValue > 21)
                    {
                        Console.WriteLine("Dealer got over 21");
                        isRunning = false;
                    }
                }
                Console.WriteLine("Dealer got {0}\n", dealerCardValue); // Displays total sum of cards
            } while (isRunning == true);

        }
    }
}
