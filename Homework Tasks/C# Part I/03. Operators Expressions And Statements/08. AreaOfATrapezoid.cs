/* Write an expression that calculates trapezoid's area by given sides a and b and height h. */

using System;

class AreaOfATrapezoid
{
    static void Main()
    {
        Console.Write("Enter your trapezoid's side A: ");
        decimal sideA = decimal.Parse(Console.ReadLine());

        Console.Write("Enter your trapezoid's side B: ");
        decimal sideB = decimal.Parse(Console.ReadLine());

        Console.Write("Enter your trapezoid's height: ");
        decimal heightH = decimal.Parse(Console.ReadLine()); ;

        decimal trapezoidArea = ((sideA + sideB) / 2) * heightH;
        Console.WriteLine("\nYour trapezoid's area is: {0}.\n", trapezoidArea);
    }
}

