using System;

class SubStringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        pattern = pattern.ToLower();
        text = text.ToLower();
        int ind = text.IndexOf(pattern, 0);
        int counter = 0;
        while (ind != -1)
        { 
            counter++;
         ind = text.IndexOf(pattern, ind + 1);    
        }
        Console.WriteLine(counter);
    }
}
