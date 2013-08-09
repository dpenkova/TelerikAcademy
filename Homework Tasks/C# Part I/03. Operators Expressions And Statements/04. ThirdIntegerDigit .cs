/* Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true. */

using System;

class ThirdIntegerDigit 
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int myNumber = Int32.Parse(Console.ReadLine());
        int thirdDigit = (myNumber / 100) % 10;
        bool result = (thirdDigit == 7);

        Console.WriteLine("\nThe check if the third digit (right-to-left) of the integer {0} is equal to 7 returns the result: {1}. \n", myNumber, result);

    }
}

