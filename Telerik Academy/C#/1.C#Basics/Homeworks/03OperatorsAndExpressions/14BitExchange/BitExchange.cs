using System;
    class BitExchange
{
    static void Main()
    {
        ulong n = uint.Parse(Console.ReadLine());
        ulong mask = 1;
        ulong bit3 =(ulong) ((mask << 3) & n) >> 3;
        ulong bit4 = (ulong)((mask << 4) & n) >> 4;
        ulong bit5 = (ulong)((mask << 5) & n) >> 5;
        ulong bit24 = (ulong)((mask << 24) & n) >> 24;
        ulong bit25 = (ulong)((mask << 25) & n) >> 25;
        ulong bit26 = (ulong)((mask << 26) & n) >> 26;

        if (bit3 != bit24)
        {
            n = n ^ (mask << 3);
            n = n ^ (mask << 24);
        }
        if (bit4 != bit25)
        {
            n = n ^ (mask << 4);
            n = n ^ (mask << 25);
        }
        if (bit5 != bit26)
        {
            n = n ^ (mask << 5);
            n = n ^ (mask << 26);
        }
        Console.WriteLine(n);
    }
}
