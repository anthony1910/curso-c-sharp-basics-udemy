using System;

namespace Classes
{       
    public class myCar
    {
        int topSpeed;
        string color;

        public myCar (int passedTopSpeed, string passedColor)
        {
            topSpeed = passedTopSpeed;
            color = passedColor;
        }

        public int getTopSpeed()
        {
            return topSpeed;
        }

        public void paintCar(string newColor)
        {
            color = newColor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            myCar toyota = new myCar(89, "Red");

            // Console.WriteLine(toyota.getTopSpeed().ToString();
            toyota.paintCar("Green");
            Console.ReadKey();
        }
    }
}
