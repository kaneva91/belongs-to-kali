﻿using System;
using System.Numerics;
class AddingPolynomials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger fact = 1;
        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }
        Console.WriteLine(fact);
    }
}
