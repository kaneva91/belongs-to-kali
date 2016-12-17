using System;

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string answer = "odd ";
        if (number % 2 == 0)
        {
            answer = "even ";
        }
        Console.WriteLine(answer + number);
    }
}
