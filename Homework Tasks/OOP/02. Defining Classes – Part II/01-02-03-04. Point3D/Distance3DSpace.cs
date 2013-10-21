using System;

namespace Point3D
{
    // Task 03 - Write a static class with a static method to calculate the distance between two points in the 3D space.

    // In three-dimensional Euclidean space, the distance is
    // d(p, q) = sqrt{(p_1 - q_1)^2 + (p_2 - q_2)^2+(p_3 - q_3)^2}.

    public static class Distance3DSpace
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt(((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X)) +
                ((firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y)) +
                ((firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z)));

            return distance;
        }
    }
}
