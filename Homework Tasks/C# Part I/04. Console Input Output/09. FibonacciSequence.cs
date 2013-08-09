/* Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */

using System;

class Program
{
    static void Main()
    {
        decimal memberN = 0;
        decimal memberN1 = 1;

        for (int i = 1; i <= 100; i++)
        {
            // This line was to check numbers' lenght and correct counting
            //Console.WriteLine("{0:000}: {1}   {2}", i, memberN.ToString().PadLeft(21, '.'), memberN.ToString().Length);

            Console.Write("{0}, ", memberN);
            
            decimal sum = memberN + memberN1;
            memberN = memberN1;
            memberN1 = sum;
        }

        Console.WriteLine();
    }
}

