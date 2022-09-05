using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public enum AnimalEnum // Enum for Animals
    {
        Zebra,
        Tiger,
        Flodhest
    }
    public enum GenderEnum // Enum for gender
    {
        Male,
        Female
    }
    internal class Animal
    {
        // Fields
        private string race;
        private string gender;

        // Properties
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        // Default Constructor
        public Animal()
        {

        }
        // Constructor with 2 arguments
        public Animal(string race, string gender)
        {
            this.race = race;
            this.gender = gender;
            
        }
        // Methods
        public void AnimalEat()
        {
            Console.WriteLine("The {0} {1} eats", Gender, Race);
        }
        public void AnimalDrink()
        {
            Console.WriteLine("The {0} {1} drinks", Gender, Race);
        }

    }
}
