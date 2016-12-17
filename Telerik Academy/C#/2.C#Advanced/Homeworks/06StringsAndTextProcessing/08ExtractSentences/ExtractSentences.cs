using System;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string[] sentances = text.Split('.');
        for (int i = 0; i < sentances.Length; i++)
        {
            string[] sent = sentances[i].Split(' ');
            for (int j = 0; j < sent.Length; j++)
            {
                if (sent[j] == word)
                {
                    Console.Write(sentances[i] + ". ");
                    continue;
                 
                }
            }
        }
        Console.WriteLine();
    }
}