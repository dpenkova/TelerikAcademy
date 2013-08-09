/* 02. Write a program that prints all the numbers from 1 to N, that are 
 * not divisible by 3 and 7 at the same time. */

using System;

class PrintNumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter your number (integer) N = ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid entry! Try again: ");
        }
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 || i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
