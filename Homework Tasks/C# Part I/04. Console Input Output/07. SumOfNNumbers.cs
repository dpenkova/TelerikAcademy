/*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. */

using System;

class SumOfNNumbers
{
    static void Main()
    {
        uint n; 
        int temp;
        int result = 0;

        Console.Write("Enter an integer number: ");
        while (!uint.TryParse(Console.ReadLine(), out n) || n == 0)
        {
            Console.Write("Invalid number! Try again: ");
        }
        for (int i = 1; i <=n; i++)
        {
            Console.Write("Enter number {0:00}: ", i);
            while (!int.TryParse(Console.ReadLine(), out temp))
            {
                Console.Write("Invalid number! Try again: ");
            }
            result = temp + result;
        }
        Console.WriteLine("\nThe sum of your {0} numbers is : {1}", n, result);
    }
}

