using System;
using System.Text;

class inputingLength
{
    static void Main()
    {
        StringBuilder input = new StringBuilder(20);
        input.Append(Console.ReadLine());
        if (input.Length < 20)
        {
            for (int i = input.Length; i < 20; i++)
            {
                input.Append("*");
            }
        }
        Console.WriteLine(input);
    }
}
