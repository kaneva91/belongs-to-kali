using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> input = new List<int>();
        List<int> sorted = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            input.Add(m);
        }
        for (int i = 0; i < n; i++)
        {
            sorted.Add(input.Min());
            input.Remove(input.Min());
        }
        foreach (int item in sorted)
        {
            Console.WriteLine(item);
        }
        
    }
}
