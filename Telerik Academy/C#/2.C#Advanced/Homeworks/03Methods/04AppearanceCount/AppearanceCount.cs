using System;

class AppearanceCount
{
    static int Countring(string[] content, string chek)
    {
        int count = 0;
        for (int i = 0; i < content.Length; i++)
        {
            if (content[i] == chek)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] numbers = new string[n];
        numbers = input.Split(' ');
        string toCheck = Console.ReadLine();
        Console.WriteLine(Countring(numbers, toCheck));
    }
}
