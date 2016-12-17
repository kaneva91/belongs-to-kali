using System;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int count = 0;
        int bestCount = 0;
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[j] == arr[i])
                {
                    count++;
                }          
            }
            if (count > bestCount)
            {
                bestCount = count;
                index = i;
            }
            count = 0;

        }
        Console.WriteLine("{0} ({1} times)", arr[index], bestCount);
    }
}
