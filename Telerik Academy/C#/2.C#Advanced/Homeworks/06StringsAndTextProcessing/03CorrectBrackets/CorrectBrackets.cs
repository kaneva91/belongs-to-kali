using System;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] =='(')
            {
                counter++;
            }
            else if (input[i] == ')')
            {
                counter--;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}
