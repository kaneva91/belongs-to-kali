using System;

class CompareCharArrays
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        int result = string.Compare(first, second, true);
        Console.WriteLine(result);
    }
}
