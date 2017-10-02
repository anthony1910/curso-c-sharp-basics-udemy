using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* array de strings
            string[] myArray = new string[] { "Learn", "app", "development" };

            string word = myArray[1];

            Console.WriteLine(word);
            Console.ReadKey();
            */

            int[] intArray = new int[] { 232, 373, 32651 };

            int arrayLength = intArray.Length;

            Console.WriteLine(arrayLength.ToString()); // Se esforçar em colocar ToString() quando for falar de strings
            Console.ReadKey();
        }
    }
}
