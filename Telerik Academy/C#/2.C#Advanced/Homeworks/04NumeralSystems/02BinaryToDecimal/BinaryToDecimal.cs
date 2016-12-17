using System;
using System.Numerics;

class BinaryToDecimal
{
    static void Main()
    {
        string binary = Console.ReadLine();
        BigInteger sum = 0;

        foreach (char bit in binary)
        {
            sum = (bit - '0') + sum * 2;  // bit - "0" returns 1 or 0
        }
        Console.WriteLine(sum);
    }
}
