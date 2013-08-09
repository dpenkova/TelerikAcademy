/* Write a program that finds the greatest of given 5 variables. */

using System;

class GreatestOfFiveVariables
{
    static void Main()
    {
        double firstNum, secondNum, thirdNum, fourthNum, fifthNum; 
        double temp = 0;

        Console.Write("Enter your fist number: ");
        while (!double.TryParse(Console.ReadLine(), out firstNum))
        {
           Console.Write("Invalid entry! Try again: "); 
        }
        Console.Write("Enter your second number: ");
        while (!double.TryParse(Console.ReadLine(), out secondNum))
        {
           Console.Write("Invalid entry! Try again: "); 
        }
        Console.Write("Enter your third number: ");
        while (!double.TryParse(Console.ReadLine(), out thirdNum))
        {
           Console.Write("Invalid entry! Try again: "); 
        }
        Console.Write("Enter your fourth number: ");
        while (!double.TryParse(Console.ReadLine(), out fourthNum))
        {
           Console.Write("Invalid entry! Try again: "); 
        }
        Console.Write("Enter your fifth number: ");
        while (!double.TryParse(Console.ReadLine(), out fifthNum))
        {
           Console.Write("Invalid entry! Try again: "); 
        }

        if (firstNum > secondNum)
        {
            temp = firstNum;
        }
        else
        {
            temp = secondNum;
        }
        if (thirdNum > temp)
        {
            temp = thirdNum;
        }
        if (fourthNum > temp)
        {
            temp = fourthNum;
        }
        if (fifthNum > temp)
        {
            temp = fifthNum;
        }

        Console.WriteLine("\nThe biggest number is: {0}\n", temp);
    }
}
