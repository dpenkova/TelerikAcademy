/*09. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
Cn = (2*n)! / (n+1)!*n!
Write a program to calculate the Nth Catalan number by given N. */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter one number N >= 0: ");
        int n = int.Parse(Console.ReadLine());
        int k = n + 1;

        BigInteger factorielK = 1;
        for (int i = k + 1; i <= 2 * n; i++)
        {
            factorielK = factorielK * i;
        }
        BigInteger factorielN = 1;
        for (int i = 1; i <= n; i++)
        {
            factorielN *= i; 
        }
        Console.WriteLine("The {0}th Catalan number is: {1}", n, factorielK / factorielN);
    }
}
