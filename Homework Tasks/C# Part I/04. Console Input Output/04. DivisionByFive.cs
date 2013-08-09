/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
 * the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2. */

using System;

class DivisionByFive
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int divisionCounter = 0;

        if (firstNumber > secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    divisionCounter++;
                }
            }
        }
        else
        {
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    divisionCounter++;
                }
            }
        }

        Console.WriteLine("\np({0},{1}) = {2}", firstNumber, secondNumber, divisionCounter);
    }
}

