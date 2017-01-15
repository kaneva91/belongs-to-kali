using System.Text;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        private static readonly Point3D StartPoint;

        static Point3D()
        {
            StartPoint = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("X: " + this.X + ", Y: " + this.Y + ", Z: " + this.Z);
            return result.ToString();
        }
    }
}
