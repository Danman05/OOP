using System;
using System.Collections.Generic;

namespace H1Blackjack
/*
                                                                       Made by Daniel H1 Ringsted ZBC
                                                                              ╔╗╔╗╔═╗╔╗╔╗╔══╗
                                                                              ║╚╝║║╚╣║║║║║╔╗║
                                                                              ║╔╗║║╔╣║╚╣╚╣╚╝║
                                                                              ╚╩╩╩╩═╩╩═╩═╩══╝
                               // Hello sign is from, https://textart4u.blogspot.com/2012/03/hello-text-art-ascii-art.html
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice; // string for user choice, if user wants to hit or stand
            bool playersTurn = true; // When true and PickUpCard method is called, player will pick up cards, if false dealer will get cards
            bool playerBust = false; // staticly set as false, if player gets over 21 it will be set to true and game is over
            bool dealersTurn = true; // while this value is true, dealer will pick up an card until his card sum isn't lower than 17

            Deck cardDeck = new Deck(); // Makes new object from Deck.cs class

            for (int i = 0; i < 2; i++) // runs 2 times, gives player 2 starting cards
            {
                cardDeck.PickUpCard(playersTurn);
            }
            playersTurn = false;
            for (int i = 0; i < 2; i++) // runs 2 times, gives dealer 2 cards
            {
                cardDeck.PickUpCard(playersTurn);
            }
            cardDeck.DisplayTableContent(); // Runs DisplayTableContent method, which outputs players cards and sum, also shows dealers first card

            do  // do-while loop, stops when user gives input S
            {
                Console.WriteLine("What is your choice [S]tand / [H]it");
                choice = Console.ReadLine().ToLower(); // saves user input and converts it camelcase

                if (choice == "h") // runs if user choice is h
                {
                    playersTurn = true; // sets to true so player can gain another card
                    cardDeck.PickUpCard(playersTurn);
                }
                cardDeck.DisplayTableContent(); // Updates the table, so it shows the new cards

                if (cardDeck.PlayerCardSum > 21) // Stops the game if PlayerCardSum is greater than 21. Game over
                {
                    playerBust = true;
                    Console.WriteLine("Your hand is over 21, dealer wins");
                    break;
                }
            } while (choice != "s");

            if (playerBust == false) // if statement runs if player hasn't gone bust
            {
                do // do-while loop, stops until dealers card sum is or larger than 17
                {
                    if (cardDeck.DealerCardSum < 17)
                    {
                        playersTurn = false;
                        cardDeck.PickUpCard(playersTurn);
                    }
                    else
                    {
                        dealersTurn = false;
                    }
                } while (dealersTurn == true);

                for (int i = 1; i < cardDeck.dealerCards.Count; i++) // for loop to display the dealers new cards, dealerCards[0] is already present, so the for loop variable i starts at 1
                {
                    Console.WriteLine(cardDeck.dealerCards[i]);
                }

                while (true) // Keeps running until loop is broken
                {
                    if (cardDeck.DealerCardSum > 21) // if dealers card sum is larger than 21, game over player wins!
                    {
                        Console.WriteLine("Dealers card sum: " + cardDeck.DealerCardSum);
                        Console.WriteLine("Dealer has gone bust, you win!");
                        break;
                    }

                    if (cardDeck.DealerCardSum == cardDeck.PlayerCardSum) // if card sum is the same, tie!
                    {
                        Console.WriteLine("Dealers card sum: " + cardDeck.DealerCardSum);
                        Console.WriteLine("It's a tie!");
                        break;
                    }

                    else if (cardDeck.PlayerCardSum > cardDeck.DealerCardSum) // else if player card sum is greater than dealers card sum, game over player wins!
                    {
                        Console.WriteLine("Dealers card sum: " + cardDeck.DealerCardSum);
                        Console.WriteLine("You win!");
                        break;
                    }

                    else if (cardDeck.PlayerCardSum < cardDeck.DealerCardSum) // else if player card sum is less than dealers card sum, game over dealer wins!
                    {
                        Console.WriteLine("Dealers card sum: " + cardDeck.DealerCardSum);
                        Console.WriteLine("Dealer wins!");
                        break;
                    }
                }
            }
            Console.ReadLine(); // Readline to keep program running
        }
    }
}
