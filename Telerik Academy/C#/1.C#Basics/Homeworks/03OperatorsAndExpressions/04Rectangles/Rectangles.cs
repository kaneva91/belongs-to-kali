using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f2} {1:f2}", width*height, 2*width + 2*height);
        
    }
}