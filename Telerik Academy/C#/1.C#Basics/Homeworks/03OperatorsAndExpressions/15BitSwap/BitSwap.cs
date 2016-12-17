using System;

class BitSwap
{
    static void Main()
    {
        ulong n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        ulong mask = 1;
        for (int i = 0; i < k; i++)
        {
            ulong bitN = (ulong)((mask << (i + p)) & n) >> (i + p);
            ulong bitQ = (ulong)((mask << (i + q)) & n) >> (i + q);
            if (bitN != bitQ)
            {
                n = n ^ (mask << (i + p));
                n = n ^ (mask << (i + q));
            }
        }
        Console.WriteLine(n);
    }
}
