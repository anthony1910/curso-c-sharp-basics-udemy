using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Anthony";

            try
            {
                int myNum = Convert.ToInt16(myName); // Erro de conversão
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
