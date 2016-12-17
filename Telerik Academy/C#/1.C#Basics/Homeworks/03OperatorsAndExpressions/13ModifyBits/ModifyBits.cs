using System;

class ModifyBits
{
    static void Main()
    {
        ulong n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        uint v = uint.Parse(Console.ReadLine());
        ulong mask =(ulong)1 << p;
        ulong bit = (n & mask) >> p;
        if (bit != v)
        {
            n = n ^ mask;
        }
        Console.WriteLine(n);
    }
}
