using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factNK = 1; // = n!/k!
        BigInteger faktNminK = 1; // = (n - k)!
        for (int i = n; i > k; i--)
        {
            factNK *= i;
        }
        for (int i = 1; i <= n - k; i++)
        {
            faktNminK *= i;
        }
        Console.WriteLine(factNK/faktNminK);
    }
}