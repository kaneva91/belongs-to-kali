using System;
using System.Numerics;

class DecimalToBinary
{
    static void Main()
    {
        BigInteger decNum = BigInteger.Parse(Console.ReadLine());
        string binary = String.Empty;
        do
        {
            BigInteger bit = decNum & 1;   // bit = decValue % 2;
            binary = bit + binary;  // append it
            decNum >>= 1;           // decNum / 2
        } while (decNum != 0);
        Console.WriteLine(binary);
    }
}
