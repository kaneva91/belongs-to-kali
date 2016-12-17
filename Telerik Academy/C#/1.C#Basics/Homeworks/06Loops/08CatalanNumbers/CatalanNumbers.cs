using System;
using System.Numerics;

class CatalanNumbers
{      //Catalan Nth number = (2n)!/(n!(n + 1)!)
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger fact2N = 1;
        BigInteger factNplus1 = 1;
        for (int i = n + 1; i <= 2*n; i++)
        {
            fact2N *= i;
        }
        for (int i = 2; i <= n + 1; i++)
        {
            factNplus1 *= i;
        }        
        Console.WriteLine(fact2N/factNplus1);      
    }
}