/* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10 -> N! = 3628800 -> 2
	N = 20 -> N! = 2432902008176640000 -> 4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why! */

using System;

class FactorielTrailingZeros
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        
        int divider = 1;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            divider = divider * 5;
            if (divider <= n)
            {
                sum = sum + (n / divider);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("{0}! has {1} trailing zeros.", n, sum);
    }
}
