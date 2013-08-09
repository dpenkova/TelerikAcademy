/* 04. Write a program that calculates N!/K! for given N and K (1<K<N). */

using System;
using System.Numerics;

class CalculateNFactorielDividedByKFactoriel
{
    static void Main()
    {
        int numberN, numberK;
        Console.Write("Enter your number N (N > 1): ");
        numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter your number K (K < N): ");
        numberK = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        for (int i = 1; numberK + i <= numberN; i++)
        {
            result = result * (numberK + i);
        }
        Console.WriteLine("The result of {0}! / {1}! = {2}", numberN, numberK, result);
    }
}
