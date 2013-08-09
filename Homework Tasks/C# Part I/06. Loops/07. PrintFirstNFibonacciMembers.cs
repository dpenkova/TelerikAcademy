/* 07. Write a program that reads a number N and calculates the sum of the first N members 
 * of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */

using System;
using System.Numerics;

class PrintFirstNFibonacciMembers
{
    static void Main()
    {
        
        Console.Write("Enter your number N = ");
        int numberN = int.Parse(Console.ReadLine());

        BigInteger memberN = 0;
        BigInteger memberN1 = 1;

        for (int i = 1; i <= numberN; i++)
        {
            Console.Write("{0}", memberN);

            if (i != numberN)
            {
                Console.Write(", ");
            }
            BigInteger sum = memberN + memberN1;
            memberN = memberN1;
            memberN1 = sum;
        }
        Console.WriteLine();
    }
}
