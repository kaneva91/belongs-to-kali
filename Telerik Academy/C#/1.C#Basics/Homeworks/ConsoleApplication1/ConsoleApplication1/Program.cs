using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        int[] mixed = new int[n - 1];
        int[] substracted = new int[n - 1];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            int a = nums[i] / 10;
            int b = nums[i] % 10;
            int c = nums[i + 1] / 10;
            int d = nums[i + 1] % 10;
            mixed[i] = b * c;
            substracted[i] = Math.Abs(nums[i] - nums[i + 1]);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
        }
        Console.WriteLine(String.Join(" ", mixed));
        Console.WriteLine(String.Join(" ", substracted));

    }
}
