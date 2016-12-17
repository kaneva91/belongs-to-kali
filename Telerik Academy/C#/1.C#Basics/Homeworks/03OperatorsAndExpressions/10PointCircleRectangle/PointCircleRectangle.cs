using System;

class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double isInCircle = Math.Sqrt(Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2));
        if (isInCircle <= 1.5)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }
        if ((y <= 1 && y >= -1) && (x <= 5 && x >= -1))
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");   
        }
    }
}
