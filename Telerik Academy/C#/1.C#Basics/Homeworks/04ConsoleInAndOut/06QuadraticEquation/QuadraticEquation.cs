using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("no real roots");
        }
        double d = Math.Pow(b, 2) - 4 * a * c;
        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            Console.WriteLine("{0:f2}", -b/(2*a));
        }
        else
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("{0:f2}\n{1:f2}", Math.Min(x1,x2), Math.Max(x1,x2));
        }
        
    }
}
