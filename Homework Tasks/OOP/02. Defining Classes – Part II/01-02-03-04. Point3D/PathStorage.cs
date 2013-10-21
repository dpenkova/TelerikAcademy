using System;
using System.Collections.Generic;
using System.IO;

namespace Point3D
{
    // Task  04 - Create a class Path to hold a sequence of points in the 3D space. 
    // Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

    public static class PathStorage
    {
        private static readonly string pathSeparator = "---"; 

        public static void SavePath(Path input)
        {
            using (StreamWriter writer = new StreamWriter(@"../../PathsList.txt", true))
            {
                foreach (var point in input.PathList)
                {
                    writer.WriteLine(point);
                }
                writer.WriteLine(pathSeparator);
            }
        }

        public static List<Path> LoadPaths(string file)
        {
            List<Path> loadedPaths = new List<Path>();
            Path currentPath = new Path();

            using (StreamReader reader = new StreamReader(file))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    if (currentLine != pathSeparator)
                    {
                        double x, y, z;
                        string[] pointXYZ = currentLine.Split(new char[] { ')', '(', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        if (
                            pointXYZ.Length == 3 &&
                            double.TryParse(pointXYZ[0], out x) &&
                            double.TryParse(pointXYZ[1], out y) &&
                            double.TryParse(pointXYZ[2], out z)
                            )
                        {
                            Point3D currentPoint = new Point3D(x, y, z);
                            currentPath.AddPoint(currentPoint);
                        }

                    }
                    else if (currentLine == pathSeparator)
                    {
                        loadedPaths.Add(currentPath);
                        currentPath = new Path();
                    }

                    currentLine = reader.ReadLine();
                }
            }

            return loadedPaths;
        }
    }
}
