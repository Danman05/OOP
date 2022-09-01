using System;
using System.Collections.Generic;

namespace Planeterne // Made by Daniel, ZBC Ringsted H1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planetsFreezing = new List<Planet>(); // Makes planets list for planets under 0 degress
            List<Planet> planetsDiameter = new List<Planet>(); // Makes planets list for planets with an diameter between 10.000 - 50.000

            List<Planet> planets = new List<Planet>(); // Makes planets list'

            Planet mercury = new Planet("Mercury", 167, 4879); // Create objects for each planet
            Planet venus = new Planet("Venus", 464, 12014);
            Planet earth = new Planet("Earth", 15, 12756);
            Planet mars = new Planet("Mars", -65, 6792);
            Planet jupiter = new Planet("Jupiter", -110, -142984);
            Planet saturn = new Planet("Saturn", -140,120536);
            Planet uranus = new Planet("Uranus", -195, 51118);
            Planet neptune = new Planet("Neptune", -200, 49528);
            Planet pluto = new Planet("Pluto", -225, 2370);


            //***** Task 3 *****

            planets.Add(mercury); // Adds planets to list in order from the suns distance
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            
            Console.WriteLine("First list;");
            Console.WriteLine("Venus is missing from this list;\n");
            foreach (Planet p in planets) // For each loop to write every planet in this list
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine();// space line

            // ***** Task 4 *****

            planets.Insert(1, venus); // The planet venus was "accidentally" forgotten in the list, and has to be added between index 0 and 1

            // ***** Task 5 *****
            Console.WriteLine("Second list;");
            Console.WriteLine("Venus is now in this list;\n");
            foreach (Planet p in planets) // For each loop to write every planet in this list
            {
                Console.WriteLine(p.Name);
            }

            // ***** Task 6 *****

            for (int i = 0; i < planets.Count; i++) // for loop will run the amount of items there is in the list
            {
                if (planets[i] == pluto) // checks if planets[i] holds the value "Pluto", if so it will get removed
                {
                    planets.Remove(pluto);
                }
            }
            Console.WriteLine();// Space line 

            Console.WriteLine("Third list;");
            Console.WriteLine("Pluto is now removed from the list;\n");
            foreach (Planet p in planets) // For each loop to write every planet in this list
            {
                Console.WriteLine(p.Name);
            }
            // ***** Task 7 *****

            planets.Insert(8, pluto); // Adds pluto back to the list,

            // ***** Task 8 *****

            Console.WriteLine("\nPluto er nu indstat i listen igen, Der er {0} planeter i listen", planets.Count);

            // ***** Task 9 *****
            foreach (Planet p in planets)
            {
                if (p.Temperature < 0) // Checks all planets in planets list, if their temperatur is under 0 degrees, then they will get added to an other list
                {
                    planetsFreezing.Add(p);
                }
            }
            Console.WriteLine("\nPlanet list with planets under 0 degress");
            foreach (Planet p in planetsFreezing) // For each loop to write every planet in this list
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine(); // Space line

            // ***** Task 10 *****
            foreach (Planet p in planets) // loops check each planet, if planets diameter is between 10.000 and 50.0000 then it will get added to a new list
            {
                if (p.Diameter > 10000 && p.Diameter < 50000)
                {
                    planetsDiameter.Add(p);
                }
            }
            Console.WriteLine("\nPlanet list with planets diameter between 10000 and 50000 km");
            foreach (Planet p in planetsDiameter) // For each loop to write every planet in this list
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine();// Space line

            // ***** Task 11 *****

            Console.WriteLine("Planet diameter list has been cleared, otherwise the planets would display below;");
            planetsDiameter.Clear(); // Clears the planetsDiameter list entirely

            foreach (Planet p in planetsDiameter) // Foreach loop validates that it has beeb cleared 
            {                                     // the loop tries to display all the content in the list, but will write nothing
                Console.WriteLine(p.Name);
            }
            

        }
        
    }
}
