/* 08. Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
* Use the Euclidean algorithm (find it in Internet). */

using System;

class GreatestCommonDivisor 
{
    static void Main()
    {
        Console.Write("Enter number one, A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number one, B = ");
        int b = int.Parse(Console.ReadLine());

        if (b > a)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        int x = a - b;

        while (x != 0)
        {
            int y;
            y = b - ((b / x) * x);
            b = x;
            x = y;
        }

        // Another way

        //while (a != 0)
        //{
        //    if (b > a)
        //    {
        //        int temp = a;
        //        a = b;
        //        b = temp;
        //    }
        //    a = a % b;    
        //}

        Console.WriteLine("The greatest common divisor is: {0}", b);
    }
}
