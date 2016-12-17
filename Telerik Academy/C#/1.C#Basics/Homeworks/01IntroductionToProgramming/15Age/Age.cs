using System;

class Age
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime age = DateTime.ParseExact(input, "MM.DD.YYYY", null);
    }
}