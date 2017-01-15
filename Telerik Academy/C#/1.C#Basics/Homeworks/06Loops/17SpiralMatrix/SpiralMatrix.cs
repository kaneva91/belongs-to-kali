using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        string direction = "right";
        int row = 0;
        int col = 0;
        int q = -1;
        int end = n * n;
        for (int i = 1; i <= end; i++)
        {
            if (direction == "right")
            {
                if (col < n)
                {
                    matrix[row, col] = i;
                    col++;
                }
                else
                {
                    direction = "down";
                    col--;
                    row++;
                    i--;
                    
                }
            }

            else if (direction == "down")  
            {
                if (row < n)
                {
                    matrix[row, col] = i;
                    row++;
                }
                else
                {
                    direction = "left";
                    row--;
                    col--;
                    n--;
                    i--;
                    
                }
            }
            else if (direction == "left")
            {
                if (col > q)
                {
                    matrix[row, col] = i;
                    col--;
                }
                else
                {
                    direction = "up";
                    col++;
                    q++;
                    i--;
                    row--;
                }
            }
            else if (direction == "up")
            {
                if (row > q)
                {
                    matrix[row, col] = i;
                    row--;
                }
                else
                {
                    direction = "right";
                    col++;
                    row++;
                    i--;
                }
            }
        }

        for (row = 0; row < Math.Sqrt(end); row++)
        {
            for (col = 0; col < Math.Sqrt(end); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

}
