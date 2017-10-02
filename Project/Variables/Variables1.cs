using System;

public class Class1
{
	public Class1()
	{
        int grantAge = 18;

        grantAge = 19;
        //grantAge = "19"; // Não é possível converter de int para string. C# é fortemente tipado

        float grantAgeInMonths = 360.87f;

        double ageInYears = 18.55;

        bool trueOrFalse = true;

        string mySentence = "My name is Anthony";

        mySentence = "name is João"; // Funciona. Entretanto, se string possuir const, não consigo mudar
    }
}
