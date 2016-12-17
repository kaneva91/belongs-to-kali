using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        angle = Math.PI * angle / 180.0;
        double surface = 0.5 * (a * b * (Math.Sin(angle)));
        Console.WriteLine("{0:f2}", surface );       
    }
}
