using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals; // Using Animals namespace
using ZooKeepers; // Using ZooKeepers namespace

namespace FoodDispensers // Different namespace so ZooKeeper can use it by, Using in the top of the code 
{
    public enum Foods // Enum for foods
    {
        Meat,
        Corn,
        Banana,
        Grass
    }
    class FoodDispenser
    {
        private string foodType;
        private static FoodDispenser instance = null; // for singleton

        // Properties
        public string FoodType
        {
            get { return foodType; }
            set { foodType = value; }
        }
        
        // Default constructor
        private FoodDispenser() 
        {
        }

        // Singleton
        public static FoodDispenser Instance
        {
            get
            {
                instance ??= new FoodDispenser();//compound statement ??= same as nullable
                return instance;
            }
        }

        // Constructor with 1 arguement
        public FoodDispenser(string foodType)
        {
            this.foodType = foodType;
        }

        // Method for dispensing food
        public string DispenseFood()
        {
            
            Animals.Animal a = new Animals.Animal();
            
            switch (a.Race)
            {
                
                case "Tiger":
                    foodType = Foods.Meat.ToString();
                    return foodType;
                    
                case "Zebra":
                    foodType = Foods.Corn.ToString();
                    return foodType;
                case "Flodhest":
                    foodType = Foods.Grass.ToString();
                    return foodType;
                default:
                    Console.WriteLine();
                    string str = "";
                    return str;
            }
        }
    }
}
