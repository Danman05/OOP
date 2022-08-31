using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshatten
{
    class SortingHat
    {
        // Constructor
        public SortingHat()
        {
            
        }
        // Method
        public string DormChooser()
        { 
            Random rnd = new Random();
            int random = rnd.Next(0, 4); // Random number between 0-3
            string str = ((Dorms)random).ToString(); // Uses the random number to get the word from the enum, and makes the enum word toString
            return str; // Returns str
        }
    }
}
