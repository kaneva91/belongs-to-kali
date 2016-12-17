using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
        long oddProduct = 1;
        long evenProduct = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= numbers[i];
            }
            else
            {
                oddProduct *= numbers[i];
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes " + evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
        }
    }
}