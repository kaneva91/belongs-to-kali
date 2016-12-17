using System;

class SequenceInMatrix
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = Int32.Parse(input[0]);
        int m = Int32.Parse(input[1]);
        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = input[j];
            }
        }

        int maxCount = 0;
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    //Console.WriteLine("bvb");
                    counter++;  
                }
                else
                {
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        counter = 0;
                    }
                }
            }
            
        }
        Console.WriteLine(maxCount + 1);
    } 
}