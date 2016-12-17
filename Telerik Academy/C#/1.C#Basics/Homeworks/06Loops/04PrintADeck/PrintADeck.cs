using System;

class PrintADeck
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] deck = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        for (int i = 0; i < 13; i++)
        {
            
            if (input != deck[i])
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
            }
            else
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]); //prints the last card
                break;
            }
        }
    }
}
