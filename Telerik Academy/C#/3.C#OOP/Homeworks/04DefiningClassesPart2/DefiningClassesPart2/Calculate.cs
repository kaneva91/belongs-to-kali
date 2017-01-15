using System;

namespace DefiningClassesPart2
{
    static class Calculate
    {
        public static double DistanceBetween(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Pow((secondPoint.X - firstPoint.Y), 2) +
                       Math.Pow((secondPoint.Y - firstPoint.Y), 2) +
                       Math.Pow((secondPoint.Z - firstPoint.Z), 2);
            return Math.Sqrt(distance);
        }
    }
}
