using System;
using System.Collections.Generic;
using System.Text;

namespace Point3D
{
    // Task  04 - Create a class Path to hold a sequence of points in the 3D space. 
    // Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

    public class Path
    {
        public readonly List<Point3D> PathList = new List<Point3D>();
       
        public void AddPoint(Point3D point)
        {
            this.PathList.Add(point);
        }

        public void ClearPath()
        {
            this.PathList.Clear();
        }

        public override string ToString()
        {
            StringBuilder printList = new StringBuilder();

            for (int i = 0; i < this.PathList.Count; i++ )
            {
                printList.AppendFormat("Point {0}: {1}\n", i, PathList[i]);
            }

            return printList.ToString();
        }
    }
}
