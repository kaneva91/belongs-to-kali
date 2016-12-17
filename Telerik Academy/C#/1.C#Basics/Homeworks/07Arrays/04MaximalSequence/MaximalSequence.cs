using System;

class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int count = 0;
        int bestCount = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < n; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                count++;
                if (count > bestCount)
                {
                    bestCount = count;
                }
            }
            else
            {
                count = 0;
            }
        }
        Console.WriteLine(bestCount + 1);
    }
}
