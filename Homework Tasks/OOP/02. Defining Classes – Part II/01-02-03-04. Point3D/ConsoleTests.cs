using System;
using System.Collections.Generic;

namespace Point3D
{
    class ConsoleTests
    {
        static void Main()
        {
            Point3D pointOne = new Point3D();
            pointOne.X = 1.3;
            pointOne.Y = -3.4;
            pointOne.Z = -5;

            Point3D pointTwo = new Point3D(2, 3, -2.5);

            Console.WriteLine("Zero point: {0}", Point3D.ZeroPoint);
            Console.WriteLine("Point one: {0}", pointOne);
            Console.WriteLine("Point two: {0}", pointTwo);

            Console.WriteLine("{0:0.00}",Distance3DSpace.CalculateDistance(Point3D.ZeroPoint, pointOne));

            Console.WriteLine("Distance between points {0} and {1} equals: {2: 0.00}", pointOne, pointTwo, Distance3DSpace.CalculateDistance(pointOne, pointTwo));

            Console.WriteLine("Distance: {0: 0.00}", Distance3DSpace.CalculateDistance(new Point3D(1, 1, 1), new Point3D(-1, -1, -1)));

            Path pathOne = new Path();
            pathOne.AddPoint(new Point3D(1, 2, 3));
            pathOne.AddPoint(new Point3D(-1, -2, -3));
            pathOne.AddPoint(new Point3D(3, 2, 1));

            Path pathTwo = new Path();
            pathTwo.AddPoint(new Point3D(4, 5, 6));
            pathTwo.AddPoint(new Point3D(-4, -5, -6));
            pathTwo.AddPoint(new Point3D(6, 5, 4));
            pathTwo.AddPoint(new Point3D(-6, -5, -4));

            Console.WriteLine(pathOne);
            Console.WriteLine(pathTwo);

            PathStorage.SavePath(pathOne);
            PathStorage.SavePath(pathTwo);

            List<Path> loadedPaths =  PathStorage.LoadPaths(@"../../PathsList.txt");

            Console.WriteLine("Loaded paths:\n-------------");

            for (int i = 0; i < loadedPaths.Count; i++ )
            {
                Console.WriteLine("Path {0}:", i);
                Console.WriteLine(loadedPaths[i]);
                Console.WriteLine("---");
            }
        }
    }
}
