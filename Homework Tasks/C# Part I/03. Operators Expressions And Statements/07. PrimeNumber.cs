/* Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime. */

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter an integer <=100: ");
        int isPrime = Int32.Parse(Console.ReadLine());

        bool isPrimeResult = (isPrime % 2 > 0) && (isPrime % 3 > 0) && (isPrime % 5 > 0) && (isPrime % 7 > 0) || ((isPrime == 2) || (isPrime == 3) || (isPrime == 5) || (isPrime == 7));

        Console.WriteLine("\nThe number you entered ({0}) is Prime: {1}.\n", isPrime, isPrimeResult);
    }
}

