using System;

namespace Robotterne_kommer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //makes 3 objects from the constructors in RobotGen
            Robots robot01 = new Robots("Color", "chip", "wifi", "battery", "soap", 0, RobotType.FloorSweepingBot);
            Robots robot02 = new Robots("white", "chip", "wifi", "battery", "soap", 0, RobotType.WindowCleanerBot);
            Robots robot03 = new Robots("white", "chip", "wifi", "battery", "soap", 0, RobotType.WheelBot);

            //write out the result to the console
            Console.WriteLine(robot01);
            Console.WriteLine(robot02);
            Console.WriteLine(robot03);
        }
    }
}