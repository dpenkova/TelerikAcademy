/* Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... */

using System;

class SumWithAccuracy
{
    static void Main()
    {
        int division = 2;
        decimal sum1 = 1m;
        decimal sum2 = 0m;
        decimal difference = 1m;
        int sign = 1;

        while (!(difference < 0.001M))
        {

            sum1 = sum1 + (1.0m / division) * sign;
            division++;
            sign = sign * (-1);
            difference = Math.Abs(sum2 - sum1); ;
            sum2 = sum1;

        }

        Console.WriteLine("Result: {0:0.000}", sum1);
    }
}
