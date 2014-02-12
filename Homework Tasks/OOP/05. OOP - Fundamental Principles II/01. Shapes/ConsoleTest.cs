/*  Task 01:
    Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure
(height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that 
at initialization height must be kept equal to width and implement the CalculateSurface() method. 
    Write a program that tests the behavior of the CalculateSurface() method for different shapes 
(Circle, Rectangle, Triangle) stored in an array.
 */

namespace Shapes
{
    class ConsoleTest
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(4, 6),
                new Rectangle(2.3, 3.5),
                new Circle(5.6),
                new Rectangle(4, 4),
                new Circle(4),
                new Triangle(12.3, 14.5)
            };

            foreach (Shape shape in shapes)
            {
                System.Console.WriteLine("{0}'s area: {1:F2}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
