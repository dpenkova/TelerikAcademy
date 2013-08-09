/* Write an expression that calculates rectangle’s area by given width and height. */

using System;

class AreaOfARectangle
{
    static void Main()
    {
        Console.Write("Enter the width of your rectangle: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of your rectangle: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("\nThe area of your rectangle is: {0}\n", width * height);
    }
}

