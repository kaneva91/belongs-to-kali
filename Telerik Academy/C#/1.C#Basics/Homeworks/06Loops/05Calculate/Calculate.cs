using System;

class Calculate
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1 + 1/x;
        long facturial = 1;
        for (int i = 2; i <= n; i++)
        {
            facturial *= i;
            sum += facturial / Math.Pow(x, i);   
        }
        Console.WriteLine("{0:f5}", sum);
    }
}
