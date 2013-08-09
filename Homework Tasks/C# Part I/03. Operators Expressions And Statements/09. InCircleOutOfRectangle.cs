/* Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
 * and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class InCircleOutOfRectangle
{
    static void Main()
    {
        Console.Write("Enter your point X coordinate: ");
        decimal pointX = decimal.Parse(Console.ReadLine());

        Console.Write("Enter your point Y coordinate: ");
        decimal pointY = decimal.Parse(Console.ReadLine());

        decimal pointRadius = 3m;

        bool resultInCircle = ((pointX - 1) * (pointX - 1 )) + ((pointY - 1) * (pointY -1)) < pointRadius * pointRadius;
        Console.WriteLine("\nYour point is within the circle: {0}.\n", resultInCircle);

        bool resultOutRectangle = !((pointX >= -1) && (pointX <= 5) && (pointY >= -1) && (pointY <= 1));
        Console.WriteLine("Your point is out of the rectangle: {0}.\n", resultOutRectangle);

        bool finalResult = resultInCircle && resultOutRectangle;
        Console.WriteLine("The statement:\n\"Your point is within the circle and out of the rectangle.\"\nis: {0}", finalResult);

    }
}

