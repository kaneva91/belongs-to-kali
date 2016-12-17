using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int fill = 1;
        string direction = null;
        int r = 0;
        int c = 0;
        
        switch (symbol)
        {
            case 'a':
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = fill;
                        fill++;
                    }
                }
                break;
            case 'b':
                direction = "down";
     
                for (int i = 0; i < n; i++)
                {
                    if (direction == "down")
                    {
                        while (c != n)
                        {
                            matrix[c, r] = fill;
                            fill++;
                            c++;
                        }
                        r++;
                        direction = "up";
                        c--;
                        
                    }
                    else if (direction == "up")
                    {
                        while (c >= 0)
                        {
                            matrix[c, r] = fill;
                            fill++;
                                c--;       
                        }
                        direction = "down";
                        r++;
                        c++;
                        
                    }
                }
                break;
            case 'c':
                for (int i = n - 1; i >= 1; i--)
                {
                    r = i;
                    if (r != 0)
                    {
                        matrix[r, c] = fill;
                        fill++;
                    }
                    else if (r == 0)
                    {

                    }
                }
                break;
            case 'd'://todo
                break;
        }
        for (int row = 0; row <matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
