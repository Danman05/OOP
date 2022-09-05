using System;
using System.Collections.Generic;
using HREmployees; // Using HRemployes so they can change the name from the zookeepers
using ZooKeepers; // Using ZooKeppers namespace
using Animals; // Using Animals namespace
using FoodDispensers;// Using FoodDispensers namepsace
namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                                              This program might not work as intended
            //                                              the main goal in this program was to work with access modifiers and encapsulating 

            bool isRunning = true;

            ZooKeeper keeper = new ZooKeeper(); // object from deafult constructor in ZooKeeper

            ZooKeeper zooKeeper01 = new ZooKeeper("John",keeper.GetWorkerID()); // object from constructor in Zookeeper
            ZooKeeper zooKeeper02 = new ZooKeeper("Bob", keeper.GetWorkerID()); // object from constructor in Zookeeper

            List<ZooKeeper> keepers = new List<ZooKeeper>(); // List of zooKeepers

            keepers.Add(zooKeeper01); // Adds zooKeeper01 to keepers list
            keepers.Add(zooKeeper02); // Adds zooKeeper02 to keepers list

            Animal animal = new Animal(AnimalEnum.Tiger.ToString(), "Male"); // Creates animal object 
            FoodDispensers.FoodDispenser f = new FoodDispensers.FoodDispenser("");
            FoodDispensers.FoodDispenser food = new FoodDispensers.FoodDispenser("");
            Console.WriteLine("There is coming {0} out from the feeding machine", food.DispenseFood());


            while (isRunning == true)
            {
                Console.WriteLine("1. ZooKeepers list");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        foreach (ZooKeeper z in keepers)
                        {
                            Console.WriteLine("Worker name: {0}\nWorker ID {1}", z.Name, z.WorkerID);
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }

                
            }
        }
    }
}
