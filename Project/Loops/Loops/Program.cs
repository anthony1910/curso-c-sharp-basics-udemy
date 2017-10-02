using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* while loop
            int i = 0;

            while (i < 100)
            {
                Console.WriteLine("Value of i = " + i.ToString());                
                i++;
            }
            Console.ReadKey();
            */

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i = " + i.ToString());
            }
            Console.ReadKey();
        }
    }
}
