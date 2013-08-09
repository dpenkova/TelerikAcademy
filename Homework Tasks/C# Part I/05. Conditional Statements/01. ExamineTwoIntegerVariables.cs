/* Write an if statement that examines two integer variables and exchanges their values if 
* the first one is greater than the second one.*/

using System;

class ExamineTwoIntegerVariables
{
    static void Main()
    {
        int firstVar = 0;
        int secondVar = 0;

        Console.Write("Enter your first number (integer): ");
        while (!int.TryParse(Console.ReadLine(), out firstVar))
        {
            Console.Write("Invalid entry! Try again: ");
        }
            
        Console.Write("Enter your second number (integer): ");
        while (!int.TryParse(Console.ReadLine(), out secondVar))
        {
            Console.Write("Invalid entry! Try again: ");
        }

        bool comparisonResult = false;

        if (firstVar > secondVar)
        {
            int tempVar = firstVar;
            firstVar = secondVar;
            secondVar = tempVar;
            comparisonResult = true;
        }

        Console.WriteLine("First vaiable A > second variable B: {0}\n>> Exchange values: {0}.\nA: {1}\nB: {2}", comparisonResult, firstVar, secondVar);
    }
}

