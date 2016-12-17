using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        int maxSum = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
            if (sum < arr[i])
            {
                sum = arr[i];
            }
            else if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine(maxSum);
    }
}