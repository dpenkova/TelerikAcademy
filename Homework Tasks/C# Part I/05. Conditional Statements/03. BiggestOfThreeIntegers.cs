/* Write a program that finds the biggest of three integers using nested if statements. */

using System;

class BiggestOfThreeIntegers
{
    static void Main()
    {
        int a, b, c;

        Console.Write("Enter you first number to compare. a = ");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid entry! Try again: ");
        }
        Console.Write("Enter you second number to compare. b = ");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid entry! Try again: ");
        }
        Console.Write("Enter you third number to compare. c = ");
        while (!int.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid entry! Try again: ");
        }

        if (a == b && b == c)
        {
            Console.WriteLine("\nYour three numbers have equal values: {0}\n", a);
        }
        if (a == b && a > c)
        {
            Console.WriteLine("\nThe biggest numbers are a = b = {0}\n", a);
            return;
        }
        if (b == c && b > a)
        {
            Console.WriteLine("\nThe biggest numbers are b = c = {0}\n", b);
            return;
        }
        if (a == c && a > b)
        {
            Console.WriteLine("\nThe biggest numbers are a = c = {0}\n", a);
            return;
        }

        if (a > b)
        {
            if (b > c)
            {
                Console.WriteLine("\nThe biggest number is: a = {0}\n", a);
            }
            else // c > b
            {
                if (a > c)
                {
                    Console.WriteLine("\nThe biggest number is: a = {0}\n", a);
                }
                else
                {
                    Console.WriteLine("\nThe biggest number is: c = {0}\n", c);
                }
            }

        }
        else // b > a
        {
            if (b > c)
            {
                Console.WriteLine("\nThe biggest number is: b = {0}\n", b);
            }
            else if (c > b)
            {
                Console.WriteLine("\nThe biggest number is: c = {0}\n", c);
            }
        }
    }
}

