using System;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
       
        Array.Sort<int>(arr, new Comparison<int>((i1, i2) => i1.CompareTo(i2))); // sorts array by ascending order
        Array.Reverse(arr);  // reversatoin - array becomes sorted by descending order
        for (int i = 0; i < k; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}
