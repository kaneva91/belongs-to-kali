using System;

class GCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int result = 0;
        if (a == 0)
        {
            Console.WriteLine(b);
        }
        else if (b == 0)
        {
            Console.WriteLine(b);
        }
        else
        {
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            do
            {
            } while (reminder != 0);
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int division = (int)(max / min);
            int reminder = max - division*min;
        }
    }
}
