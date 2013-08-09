/* Sort 3 real values in descending order using nested if statements. */

using System;

class SortDescendingThreeRealValues
{
    static void Main(string[] args)
    {
        int a, b, c;

        Console.Write("Enter you first number to sort. a = ");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid entry! Try again: ");
        }
        Console.Write("Enter you second number to sort. b = ");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid entry! Try again: ");
        }
        Console.Write("Enter you third number to sort. c = ");
        while (!int.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid entry! Try again: ");
        }
       
        if (a >= b && a >= c)
        {
            if (b > c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        else if (b >= a && b >= c)
        {
            if (a > c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);    
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
        }
        else if (c >= a && c >= b)
        {
            if (a > b)
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }

    }
}

