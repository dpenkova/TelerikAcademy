/* 05. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).*/

using System;
using System.Numerics;

class CalculateNFactorielKFactorielDividedByK_NFactoriel 
{
    static void Main()
    {
        int numberN, numberK;
        Console.Write("Enter your number N (N > 1): ");
        numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter your number K (K > N): ");
        numberK = int.Parse(Console.ReadLine());

        BigInteger factorielK = 1;

        for (int i = numberK - numberN + 1; i <= numberK; i++)
        {
            factorielK = factorielK * i;
        }

        BigInteger factorielN = 1;

        for (int i = 1; i <= numberN; i++)
        {
            factorielN *= i;
        }
        Console.WriteLine("The result of {0}!*{1}!/({1}-{0})! = {2}", numberN, numberK, factorielK * factorielN);
    }
}

