using System;
using System.Threading;

namespace Elon_Musk
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();

            Random rnd = new Random();
            // Generation of random number between 1-130, this will choose how many turns the cars drive
            int turnsForCar1 = rnd.Next(1,131);
            int turnsForCar2 = rnd.Next(1, 131);

            // Generation of random number between 0-2, this will choose the cars color, Yellow, Green, or Red, from color[] in Car.cs
            int carColorC1 = rnd.Next(0, 3);
            int carColorC2 = rnd.Next(0, 3);

            // GUI Code for Car1
            Console.WriteLine("Car1 har fået farven: " + car1.color[carColorC1]);
            Console.WriteLine("Der skal køres: "+turnsForCar1+" gange\n");

            // For loop, repeats the amount of times the random generated number
            for (int i = 0; i < turnsForCar1; i++)
            {
                car1.Drive(); // Calls the method Drive in Car.cs

                if (car1.batteryLevel == 0) // If batteryLevel is 0 then break the loop
                {
                    Console.WriteLine("Bilen er løbet tør for strøm, den skal oplades\n");
                    break;
                }
            }
            // output of data for car1
            Console.WriteLine("Bilen har gennemført dens ture og har følgene oplysninger: ");
            Console.WriteLine("Strøm tilbage: " + car1.batteryLevel + "%");
            Console.WriteLine("Antal meter kørt: " + car1.metersDriven + "\n\n");

            // GUI Code for Car2
            Console.WriteLine("Car2 har fået farven: " + car2.color[carColorC2]);
            Console.WriteLine("Der skal køres: "+turnsForCar2+" gange\n");
            // For loop, repeats the amount of times the random generated number
            for (int i = 0; i < turnsForCar2; i++)
            {
                car2.Drive(); // Calls the method Drive in Car.cs
                if (car2.batteryLevel == 0) // If batteryLevel is 0 then break the loop
                {
                    Console.WriteLine("Bilen er løbet tør for strøm, den skal oplades\n");
                    break;
                }
            }
            // Output of data for car2
            Console.WriteLine("Bilen har gennemført dens ture og har følgene oplysninger: ");
            Console.WriteLine("Strøm tilbage: " + car2.batteryLevel + "%");
            Console.WriteLine("Antal meter kørt: " + car2.metersDriven);

            Console.ReadLine(); // Readline to keep program running
        }
    }
}
