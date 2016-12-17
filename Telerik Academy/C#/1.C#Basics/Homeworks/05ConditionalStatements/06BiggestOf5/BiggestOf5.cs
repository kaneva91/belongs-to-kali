using System;

class BiggestOf5
{
    static void Main()
    {
        double[] numbers = new double[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }
        double greatest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            greatest = Math.Max(numbers[i], greatest);
        }
        Console.WriteLine(greatest);
    }
}