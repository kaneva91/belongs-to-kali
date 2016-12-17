using System;

class BinarySearch
{
    public static int IntArrayBinarySearch(int[] data, int item)
    {

        int min = 0;
        int N = data.Length;
        int max = N - 1;
        do
        {
            int mid = (min + max) / 2;
            if (item > data[mid])
                min = mid + 1;
            else
                max = mid - 1;
            if (data[mid] == item)
                return mid;
            //if (min > max)
            //   break;
        } while (min <= max);
        return -1;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(IntArrayBinarySearch(arr,x));
    }
}