using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne_kommer
{
    internal class Robots
    {
        // Fields
        private RobotType model;
        private string color;
        private string chip;
        private string wifi;
        private string battery;
        private string soapContainer;
        private int batterySize;
        private int wheels;

        //encapsulation 
        public RobotType Model { get => model; }
        public string Color { get => color; }
        public string Chip { get => Chip; }
        public string Wifi { get => wifi; }
        public string Battery { get => battery; }
        public string SoapContainer { get => soapContainer; }
        public int BatterySize { get => batterySize; }
        public int Wheels { get => wheels; }


        //random generator gives number between 0 or 1
        Random random = new Random();
        int num = new Random().Next(0, 2);

        // constructor for model
        public Robots(string color, string chip, string wifi, string battery, string soapContainer, int wheels, RobotType model) : this(color, chip, wifi, battery, soapContainer, wheels)
        {
            this.model = model;
        }
        // ToString method, which enables them to return their contents as a string:
        public override string ToString()
        {
            return $"color: {color}\n chip: {chip} \n wifi: {wifi}\n battery: {battery}\n soap container: {soapContainer}\n whells: {wheels}\n model: {model}";
        }

        //constructors
        private Robots()
        {

        }
        // constructor for color
        private Robots(string color) : this()
        {
            this.color = "white";
        }
         // constructor for chip name   
        private Robots(string color, string chip) : this(color)
        {
            this.chip = num == 1 ? "RX54667" : "QT8339";
        }
        // constructor for wifi
        private Robots(string color, string chip, string wifi) : this(color, chip)
        {
            this.wifi = num == 1 ? "got wifi" : "no wifi";
        }
        // constructor for battery
        private Robots(string color, string chip, string wifi, string battery) : this(color, chip, wifi)
        {
            if (this.model == RobotType.WheelBot)
            {
                this.battery = "Got a battery";

                this.batterySize = num == 1 ? 128 : 255;
            }
        }
        // constructor for soapContainer
        private Robots(string color, string chip, string wifi, string battery, string soapContainer) : this(color, chip, wifi, battery)
        {
            if (this.model == RobotType.FloorSweepingBot || this.model == RobotType.WindowCleanerBot)
            {
                this.soapContainer = "this model has a soap contanier on 2,3L.";
            }
            else
            {
                this.soapContainer = "This model has no soap contanier.";
            }
        }
        // constructor for wheels
        private Robots(string color, string chip, string wifi, string battery, string soapContainer, int wheels) : this(color, chip, wifi, battery, soapContainer)
        {
            if (this.model != RobotType.FloorSweepingBot)
            {
                if (this.model == RobotType.WindowCleanerBot)
                {
                    this.wheels = 4;
                }
                else
                {
                    this.wheels = 6;
                }
            }
        }
    }
}