using System;
using System.Linq;
using System.Numerics;

class IntegerCalculations
{

    static int Minumum(int[] nums)
    {
        return nums.Min();
    }

    static int Maximum(int[] nums)
    {
        return nums.Max();
    }

    static double Average(int[] nums)
    {
        return nums.Average();
    
    }

    static int Sum(int[] nums)
    {
        return nums.Sum();

    }

    static BigInteger Product(int[] nums)
    {
        BigInteger product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }
        return product;
    }
    static void Main()
    {
        string input = Console.ReadLine();
        string[] content = input.Split(' ');
        int[] nums = new int[content.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(content[i]);

        }
        Console.WriteLine(Minumum(nums));
        Console.WriteLine(Maximum(nums));
        Console.WriteLine("{0:f2}", Average(nums));
        Console.WriteLine(Sum(nums));
        Console.WriteLine(Product(nums));
    }
}
