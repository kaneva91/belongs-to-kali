using System;

class MaximalSum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = Int32.Parse(input[0]);
        int m = Int32.Parse(input[1]);
        int[,] matrix = new int[n, m];
        int bestSum = int.MinValue;
        for (int i = 0; i <n; i++)
        {
            input = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
            
        }
        Console.WriteLine(bestSum);
    }
}
