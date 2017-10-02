using System;

public class Class1
{
	public Class1()
	{
        // String para Int
        int myNum = 9;

        string alsoNum = "0";

        var result = myNum + Convert.ToInt16(alsoNum);

        Console.WriteLine(result);
        Console.ReadKey();

        // Double to String
        double myNum = 786;

        string sentence = "My number is: " + myNum.ToString();

        Console.WriteLine(sentence);
        Console.ReadKey();
    }
}
