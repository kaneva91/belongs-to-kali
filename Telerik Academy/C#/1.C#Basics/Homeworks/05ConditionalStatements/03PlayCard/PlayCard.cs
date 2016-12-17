using System;

class PlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == input)
            {
                Console.WriteLine("yes " + input);
                break;
            }
            else if (i + 1 == cards.Length)
            {
                Console.WriteLine("no " + input);
            }
        }
        
    }
}
