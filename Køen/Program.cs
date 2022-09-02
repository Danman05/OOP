using System;
using System.Threading;
using System.Collections.Generic;
namespace Køen
{
    class Program
    {
        /// <summary>
        /// GUI
        /// </summary>
        
        static void Main(string[] args)
        {
            
            Queue<Games> games = new Queue<Games>(); // Makes new queue
            Console.ForegroundColor = ConsoleColor.Green; // Sets foreground color to green to look cooler

            WelcomeList welcomeList = new WelcomeList(); // Creates an object list from WelcomeList.cs

            bool isExit = false; // Variable to tell loop when to stop

            // loop that keeps running the program until bool is changed
            while (isExit == false)
            {
                Console.Write(welcomeList.DisplayMenu()); // Displays the welcome list

                ConsoleKeyInfo key = Console.ReadKey(); // Takes the first keypress and uses it for if statements
                if (key.KeyChar == '1') 
                {
                    Console.Clear();                // Ask user to add an game
                    Console.Write("Game title: ");
                    AddItems(); // Runs method
                }
                else if (key.KeyChar == '2')
                {
                    Console.Clear();
                    DeleteItems(); // Runs method
                    Console.WriteLine("Cleared the list");
                    Console.WriteLine("Press <Enter> to close"); // Guiding text
                    Console.ReadLine(); // Runs Method
                }
                else if (key.KeyChar == '3')
                {
                    Console.Clear();
                    Console.WriteLine("There is {0} games in the list",games.Count);
                    Console.WriteLine("Press <Enter> to close"); // Guiding text
                    Console.ReadLine();
                }
                else if (key.KeyChar == '4')
                {
                    Console.Clear();
                    Console.WriteLine("What game do you want to find in your list?");
                    FindItems(); // Runs Method
                    Console.WriteLine("Press <Enter> to close"); // Guiding text
                    Console.ReadLine(); 
                }
                else if (key.KeyChar == '5')
                {
                    Console.Clear();
                    PrintItems(); // Runs Method
                    Console.WriteLine("Press <Enter> to close"); // Guiding text
                    Console.ReadLine();
                }
                else if (key.KeyChar == '6') 
                {
                    isExit = true; // sets bool to true so loop breaks
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                }
            }
            void AddItems() // Method for adding an item to the queue, in this case an string
            {
                string title = Console.ReadLine();
                games.Enqueue(new Games(title));
                Console.Clear();
            }
            void DeleteItems() // Method for clearing the list
            {
                games.Clear();
                Console.Clear();
            }
            void FindItems() // Method for finding items, doesnt really work :)
            {
                string str = Console.ReadLine();
                if (games.Equals(str))
                {
                    foreach (Games g in games)
                    {
                        Console.WriteLine(g.GameTitle);
                    }
                }
                Console.Clear();
            }
            void PrintItems() // Method for printing all items inside the queue
            {
                foreach (Games g in games)
                {
                    Console.WriteLine(g.GameTitle);
                }
            }
        }
    }
}
