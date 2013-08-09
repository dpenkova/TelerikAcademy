/* 06. Write a program that, for a given two integer numbers N and X, calculates the sum
 * S = 1 + 1!/X^1 + 2!/X^2 + … + N!/X^N */

using System;
using System.Numerics;

class SumNAndXNEstedForLoop
{
    static void Main()
    {
        int n, x;
        Console.Write("Enter N = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter X = ");
        x = int.Parse(Console.ReadLine());

        decimal sum = 1;

        for (int i = 1; i <= n; i++)
        {
            decimal temp = 1m;
            decimal tempX = 1m;

            for (int j = 1; j <= i; j++)
            {
                temp = temp * j;
                tempX = tempX * x;
            }

            sum = sum + (temp / tempX);
        }
        Console.WriteLine("The result is: {0}", sum);
    }
}
