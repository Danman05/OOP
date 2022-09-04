using System;
using System.Collections.Generic;

namespace Biblioteket
{
    class Program
    {
        static void Main(string[] args)

            // This was an school assignment, it might be very messy because it was hard

            // *Note*. the action when the user loans a book and it goes to his own stack where his loaned books are, does not work. i've tried to fix it with multiple ways but no luck
        {
            bool isRunning = true;
            ConsoleKeyInfo key;

            UserOption optionList = new UserOption(); // creation of object from UserOption.cs, so while loop can display the option list from an method

            Stack<Book> loanedBook = new Stack<Book>(); // Stack for loaned books

            Stack<Book> books = new Stack<Book>(); // Making a new stack called books

            // Adding books to stack
            books.Push(new Book("Percy Jackson"));
            books.Push(new Book("Dansk Ordbog"));
            books.Push(new Book("Ildragen Ferno"));
            books.Push(new Book("Søslangen Sepron"));

            while (isRunning == true) // While loop runs while condition is met
            {
                optionList.DisplayOption();

                key = Console.ReadKey();
                if (key.KeyChar == '1') // If keyChar = 1, Display books
                {
                    Console.Clear();
                    Console.WriteLine("Displaying books...");
                    DisplayBook();
                    Console.ReadLine();
                }
                else if (key.KeyChar == '2') // if keyChar = 2, loan the book top in the stack
                {
                    Console.Clear();
                    string str = LoanABook();
                    Console.WriteLine("You have loaned: {0}", str);

                    // loanedBook.TryPop(str); Trying to get the loaned book to another stack called loanedBook, so the user can display the loaned books, but it seems to not be working
                    Console.ReadLine();
                }
                else if (key.KeyChar == '3') // if keyChar = 3, display loaned books, this thing wont work, because i cant fix it
                {
                    Console.Clear();
                    Console.WriteLine("You have loaned these book(s)");
                    LoanedBooks();
                    Console.ReadLine();
                }
                else if (key.KeyChar == '4') // if keyChar = 4, exit the program
                {
                    Console.Clear();
                    Console.WriteLine("Exitting");
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            void DisplayBook()
            {
                foreach (Book b in books)
                {
                    Console.WriteLine(b.Name);
                }
            }
            string LoanABook()
            {
                if (books.Count > 0) // aslong as there is over 0 books left, the user can keep on taking books
                {
                    Book loan = books.Pop();
                    return loan.Name;
                }
                else // if there is 0 or less books, the user gets told that there is no more books left
                {
                    string str = "No books left!";
                    return str;
                }
               
            }
            void LoanedBooks() // method for displaying loanedBooks, doesn't work :)
            {
                foreach (Book b in loanedBook)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
