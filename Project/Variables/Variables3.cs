using System;

public class Class1
{
	public Class1()
	{
        /* Comparação com if
            int myNum = 10;
            int myNumTwo = 20;
            
            if (myNum == myNumTwo)
            {
                Console.WriteLine("Numbers are equal!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Numbers are inequal!");
                Console.ReadKey();
            }
            */

        // Comparação com switch
        int myNum = 10;

        switch (myNum)
        {
            case 1:
                Console.WriteLine("Num is 1");
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("Num is 2");
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("Num is 3");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Default case");
                Console.ReadKey();
                break;
        }
    }
}
