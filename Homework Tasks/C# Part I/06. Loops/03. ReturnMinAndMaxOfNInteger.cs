/* 03. Write a program that reads from the console a sequence of N integer numbers 
 * and returns the minimal and maximal of them. */

using System;

class ReturnMinAndMaxOfNInteger
{
    static void Main()
    {
        Console.Write("Enter the number of your numbers: ");
        int numberOfNums = int.Parse(Console.ReadLine());
        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;
        int number;

        for (int i = 1; i <= numberOfNums; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number > maxNumber)
	        {
                maxNumber = number;
	        }
            if (number < minNumber)
            {
                minNumber = number;
            }
        }

        Console.WriteLine("Your maximal number is: {0}\nYour minimal number is: {1}", maxNumber, minNumber);
    }
}
