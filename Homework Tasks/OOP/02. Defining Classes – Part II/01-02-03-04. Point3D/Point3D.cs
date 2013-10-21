using System;
using System.Text;

namespace Point3D

{
    // Task 01 - Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
    // Implement the ToString() to enable printing a 3D point.

    public struct Point3D
    {
        public double X {get; set; }
        public double Y {get; set; }
        public double Z {get; set; }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            StringBuilder point = new StringBuilder();

            point.AppendFormat("({0}, {1}, {2})", this.X, this.Y, this.Z);

            return point.ToString();
        }

        // Task 02 - Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
        // Add a static property to return the point O.

        private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);

        public static Point3D ZeroPoint
        {
            get { return zeroPoint; }
        }

    }
}
