using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_Musk
{
    class Car
    {
        // Objects for the car
        public byte batteryLevel = 100; // datatype byte, to hold the percantage of power left in the car, it will always start with 100%
        public int metersDriven; // datatype int, to hold the amount of meters driven
        public string[] color = { "gul", "grøn", "rød" }; // Posible colors for cars

        // Method called Drive, will increase meters by 20, and will remove 1% of battery each time method is called
        public void Drive()
        {
            metersDriven += 20;
            batteryLevel--;
        }
        
    }
}
