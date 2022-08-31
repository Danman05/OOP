using System;

namespace Fordelingshatten
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingHat chooseDorm = new SortingHat(); // Makes new object from class SortingHat 
            Console.WriteLine(chooseDorm.DormChooser()); // Writes to console, the object and the objects method
            Console.ReadLine(); // Readline to keep program running
        }
    }
}
