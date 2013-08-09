/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. */

using System;

class PrintNNumbers
{
    static void Main()
    {
        int n;

        Console.Write("Enter an integer number (n > 1): ");

        while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Invalid entry! Try again: ");
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}

