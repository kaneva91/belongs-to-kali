using System;

class ThirdDigit
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int result = (input / 100) % 10;
        if (result == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + result);
        }
    }
}
