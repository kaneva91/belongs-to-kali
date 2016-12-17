using System;

class SayHallo
{
    static void Hallo(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        string input = Console.ReadLine();
        Hallo(input);
    }
}
