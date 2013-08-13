/* Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; 
 * Three sides; 
 * Two sides and an angle between them. Use System.Math.*/

using System;

class TriangleSurface
{
    static void Main()
    {
        double sideA = 10;
        double sideB = 11;
        double sideC = 7;

        double altitudeToA = 6.858;

        double angleDegreesBC = 62.954;

        Console.WriteLine("Trangle's surface by side A and altitude to it, is: {0: 0.00}", TriangleSurfaceBySideAndAltitude(sideA, altitudeToA));
        Console.WriteLine("Trangle's surface by three sides, is: {0: 0.00}", TriangleSurfaceByThreeSides(sideA, sideB, sideC));
        Console.WriteLine("Trangle's surface by two sides (B and C) and an angle between them, is: {0: 0.00}", TriangleSurfaceByTwoSideAndAngleBetween(sideB, sideC, angleDegreesBC));
    }

    public static double TriangleSurfaceBySideAndAltitude(double side, double altitude)
    { 
        double surface = (side * altitude ) / 2;

        return surface;
    }

    // Heron's formula
    public static double TriangleSurfaceByThreeSides(double side1, double side2, double side3)
    {
        double halfPerimeter = (side1 + side2 + side3) / 2;
        double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));

        return surface;
    }

    public static double TriangleSurfaceByTwoSideAndAngleBetween(double side1, double side2, double angleDegrees)
    {
        double angleRadians = (Math.PI / 180) * angleDegrees;
        double surface = (side1 * side2 * Math.Sin(angleRadians)) / 2;

        return surface;
    }
}
