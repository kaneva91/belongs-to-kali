using System;
using System.Collections.Generic;

class NumberAsArray
{
    static int[] NumAsArrayConversation(int size)
    {   // Converts string array to int array
        string input = Console.ReadLine();
        string[] numStrings = input.Split(' ');
        int[] nums = new int[size];
        for (int i = 0; i < size; i++)
        {
            nums[i] = int.Parse(numStrings[i]);
        }
        return nums;
    } // Sums the elements
    static void Sum(int[] arr1, int[] arr2)
    {
      
        int biggerSize = Math.Max(arr1.Length, arr2.Length);
        int smallerSize = Math.Min(arr1.Length, arr2.Length);
        int[] sum = new int[biggerSize + 1];
        for (int i = 0; i < smallerSize; i++) // sums the elements
        {
            int curSum = arr1[i] + arr2[i];   // checks if current sum is > 9
            if (curSum > 9)
            {
                curSum = curSum % 10;
                sum[i] += curSum;
                sum[i + 1] += 1;
                
            }
            else
            {
                sum[i] += curSum;
            }
        }
        for (int i = smallerSize; i < biggerSize; i++)
        {
            sum[i] += arr2[i];
        }
        for (int i = 0; i < sum.Length - 1; i++)
        {
            Console.Write(sum[i] + " ");
        }
        if (sum[sum.Length - 1] != 0)
        {
            Console.WriteLine(sum[sum.Length - 1]);
        }
        else
        {
            Console.WriteLine();
        }
    }
    static void Main()
    {
        string input = Console.ReadLine();
        string[] size = input.Split(' ');
        int m = int.Parse(size[0]);
        int n = int.Parse(size[1]);
        int[] arr1 = NumAsArrayConversation(m);
        int[] arr2 = NumAsArrayConversation(n);
        Sum(arr1, arr2);
    }
}
