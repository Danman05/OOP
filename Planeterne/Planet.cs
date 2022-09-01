using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Planet
    {
        // Fields
        private string name;
        private int temperature;
        private double diameter;
        
        // Properties
        public string Name { get { return name; } }
        public int Temperature { get { return temperature; } }
        public double Diameter { get { return diameter; } }

        // Constructor
        public Planet(string name, int temperature, double diameter)
        {
            this.name = name;
            this.temperature = temperature;
            this.diameter = diameter;

        }
    }

}
