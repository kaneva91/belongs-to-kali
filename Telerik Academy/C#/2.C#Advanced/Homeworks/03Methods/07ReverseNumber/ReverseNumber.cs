using System;

class ReverseNumber
{
    static string Reversation(string dec)
    {
        string reversed = null;
        for (int i = dec.Length - 1; i > -1 ; i--)
        {
            reversed += dec[i];
        }
        return reversed;
    }
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(Reversation(input)); 
    }
}

