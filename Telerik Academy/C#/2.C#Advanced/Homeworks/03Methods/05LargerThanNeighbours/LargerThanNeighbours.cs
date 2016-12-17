using System;

class LargerThanNeighbours
{
    static int Count(int[] nums)
    {
        int counter = 0;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] content = input.Split(' ');
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(content[i]);
        }
        Console.WriteLine(Count(numbers));
    }
}