using System;

namespace Classes
{
    public class Vehicle
    {

        int topSpeed = 90;
        string color = "Red";

        public int getTopSpeed()
        {
            return topSpeed;
        }

        public string getColor()
        {
            return color;
        }

        public Vehicle()
        {

        }

    }

    public class Truck : Vehicle
    {
        string size = "large";

        public string getSize()
        {
            return size;
        }
    }

    public class LargeTruck : Truck
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            /* class myTruck
            Truck myTruck = new Truck();
            Console.WriteLine(myTruck.getTopSpeed().ToString());
            Console.WriteLine(myTruck.getColor().ToString());
            Console.ReadKey();
            */
            LargeTruck myNewTruck = new LargeTruck();

            Console.WriteLine(myNewTruck.getSize());
            Console.ReadKey();
        }
    }
}
