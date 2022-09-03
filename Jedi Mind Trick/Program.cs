using System;
using System.Collections.Generic;

namespace Jedi_Mind_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates Dictionary
            Dictionary<string, int> people = new Dictionary<string, int>();

            //Adds "Jedi" at the age of 32
            people.Add("Jedi", 50);
            //Adds "Joda" at the age of 104
            people.Add("Joda", 104);

            //Writes each keyvaluepair in Dictionary people
            foreach (KeyValuePair<string, int> item in people)
            {
                Console.WriteLine(item);
            }

            //Creates Dictionary and add "luke, Han and Chewbacca"
            Dictionary<string, bool> Characters = new Dictionary<string, bool>()
            {
                { "Luke", true},
                { "Han", false},
                {"ChewBacca", false}
            };

            //Removes "Han"
            Characters.Remove("Han");

            //Writes each KeyValuePair in Dictionary Characters
            foreach (KeyValuePair<string, bool> item in Characters)
            {
                Console.WriteLine(item);
            }

            // Keeps program alive
            Console.ReadLine();
        }
    }
}
