﻿using System;

namespace _08.BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {  
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        }
    }
}