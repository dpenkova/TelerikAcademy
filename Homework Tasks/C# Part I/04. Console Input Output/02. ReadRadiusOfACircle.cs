/* Write a program that reads the radius r of a circle and prints its perimeter and area. */

using System;

    class ReadRadiusOfACircle
    {
        static void Main()
        {
            Console.Write("Enter the radius of your circle: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            Console.WriteLine("Area : {0}\nPerimeter: {1}", pi * radius * radius, 2 * pi * radius);

        }
    }

