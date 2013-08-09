/* Write a program to calculate n! for each n in the range [1..100].  * Hint: Implement first a method that multiplies a number represented as 
 * array of digits by given integer number. */

using System;
using System.Numerics;

class Factoriel
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i, FactorialN(i));
        }
    }

    static BigInteger FactorialN(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
