/* Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
*/

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c;

        Console.Write("Enter a value for a: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid input! Try again: ");
        }

        Console.Write("Enter a value for b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid input! Try again: ");
        }

        Console.Write("Enter a value for c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid input! Try again: ");
        }

        double sqrtpart = (b * b) - (4 * a * c);

        double x1 = ((-b) + Math.Sqrt(sqrtpart)) / (2 * a);
        double x2 = ((-b) - Math.Sqrt(sqrtpart)) / (2 * a);

        if (a == 0)
        {
            Console.WriteLine("\nThis is not a Quadratic equation!!");
            return;
        }

        if (sqrtpart < 0)
        {
            Console.WriteLine("\nThere are no real roots");
        }
        else if (sqrtpart == 0)
        {
            Console.WriteLine("\nThere are one real root x1=x2: {0}", x1);
        }
        else if (sqrtpart > 0)
        {
            Console.WriteLine("\nThere are two real roots: x1 = {0} and x2 = {1}", x1, x2);
        }

    }
}
