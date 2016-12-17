using System;

class MoonGravity
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f3}", 0.17 * weight);
    }
}
