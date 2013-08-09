/* 01. Write a program that prints all the numbers from 1 to N. */

using System;

class PrintNumbersFrom1ToN
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
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

