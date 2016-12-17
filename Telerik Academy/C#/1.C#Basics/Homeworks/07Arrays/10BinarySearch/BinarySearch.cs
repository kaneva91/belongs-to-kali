using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());
        Array.Sort<int>(arr, new Comparison<int>((i1, i2) => i1.CompareTo(i2))); //sorts the array
        int index = Array.BinarySearch(arr, x);
        if (index == -4)
        {
            index = -1;
        }
        Console.WriteLine(index);
    }
}