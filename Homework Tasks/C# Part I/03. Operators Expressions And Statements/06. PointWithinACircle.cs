/* Write an expression that checks if given point (x,  y) is within a circle K(O, 5). */

using System;
class PointWithinACircle
{
    static void Main()
    {
        Console.Write("Enter your point X coordinate: ");
        decimal pointX = decimal.Parse(Console.ReadLine());

        Console.Write("Enter your point Y coordinate: ");
        decimal pointY = decimal.Parse(Console.ReadLine());

        decimal pointRadius = 5m;

        bool result = (pointX * pointX) + (pointY * pointY) < pointRadius * pointRadius;

        Console.WriteLine("\nYour point is within the circle: {0}.\n", result);

    }
}

