using System;

class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string answer = "false ";
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            answer = "true ";
        }
        Console.WriteLine(answer + number);
    }
}
