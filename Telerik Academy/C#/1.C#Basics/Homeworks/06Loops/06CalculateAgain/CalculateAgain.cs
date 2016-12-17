using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger fact = 1;
        for (int i = n; i > k; i--)
        {
            fact = fact * i;
        }
        Console.WriteLine(fact);
    }
}
