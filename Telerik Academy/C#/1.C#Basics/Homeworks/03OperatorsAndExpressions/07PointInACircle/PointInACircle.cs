﻿using System;
class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double distance = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
        if (distance <= 2.00)
        {
            Console.WriteLine("yes {0:f2}", distance);
        }
        else
        {
            Console.WriteLine("no {0:f2}", distance);
        }

    }
}
