﻿using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        bool areEqial = true;
        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < n; j++)
        {
            arr2[j] = int.Parse(Console.ReadLine());
        }
        for (int k = 0; k < n; k++)
        {
            if (arr1[k] != arr2[k])
            {
                areEqial = false;
                break;
            }
        }
        Console.WriteLine(areEqial ? "Equal" : "Not equal");
    }
}