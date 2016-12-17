using System;

class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        string isEqual = "true";
        if (Math.Abs(a - b) > eps)
            {
                isEqual = "false";
            }
        Console.WriteLine(isEqual);    
    }
}