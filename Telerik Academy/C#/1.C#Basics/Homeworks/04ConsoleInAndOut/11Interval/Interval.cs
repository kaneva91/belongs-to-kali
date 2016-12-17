using System;

class Interval
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int result = 0;
        if (n == m)
        {
            Console.WriteLine(result);
        }
        else
        {
            for (int i = n+1; i <= m-1; i++)
            {
                if (i % 5 == 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
       
    }
}
