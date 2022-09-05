using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDispensers; // Using the namespace from FoodDispensers
using Animals; // Using the namespace from Animals


namespace ZooKeepers
{
    internal class ZooKeeper
    {
        // Fields 
        private string name;
        private int workerID;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int WorkerID
        {
            get { return workerID; }
            set { workerID = value; }
        }
        // Default constructor
        public ZooKeeper()
        {

        }
        // Constructor with 2 arguments
        public ZooKeeper(string name, int workerID)
        {
            this.name = name;
            this.workerID = workerID;
        }
        
        // Method
        public int GetWorkerID()
        {
            Random rnd = new Random();
            int iD = rnd.Next(100, 1000);
            return iD;
        }
    }
}
