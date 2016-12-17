using System;
using System.Numerics;

class DecimalToHehadecimal
{
    static void Main(string[] args)
    {
        const string HexDigits = "0123456789ABCDEF";
        BigInteger dec = BigInteger.Parse(Console.ReadLine());
        string result = string.Empty;

        do
        {
            BigInteger value = dec % 16;
            result = HexDigits[(int) value] + result;
            dec /= 16;

        } while (dec != 0);
        Console.WriteLine(result);
    }
}
