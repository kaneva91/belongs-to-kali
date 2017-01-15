using System;

class BinarySearch
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] arr = new int[input];
        int min = 0;
        int max = input - 1;
        int middle = (min + max) / 2;

        for (int i = 0; i < input; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());

        while (arr[middle] != x && min <= max)
        {
            middle = (min + max) / 2;

            if (arr[middle] < x)
            {
                min = middle + 1;
            }
            else
            {
                max = middle - 1;
            }

        }
       
        if (arr[middle] != x)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(middle);
        }
    }
}