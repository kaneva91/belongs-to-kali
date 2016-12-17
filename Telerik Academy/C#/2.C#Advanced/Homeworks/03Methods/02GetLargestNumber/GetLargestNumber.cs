using System;

class GetLargestNumber
{
    static int GetMax(int num1, int num2)
    {
        return Math.Max(num1, num2);
    } 
    static void Main()
    {
        string input = Console.ReadLine();
        string[] nums = input.Split(' ');
        Console.WriteLine(GetMax(GetMax(int.Parse(nums[0]), int.Parse(nums[1])), int.Parse(nums[2])));
    }
}
