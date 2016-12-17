using System;

class SecretNumeralSystem
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] separator = { ',', ' ' };
        string[] message = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int ind1 = 0;
        int ind2 = 0;
        int sum = 0;
        for (int i = 0; i < message.Length; i++)
        {
            ind1 = DecryptFirst(message[i]);
            Console.WriteLine(ind1);
        }
    }

    static int DecryptFirst(string msg)
    {
        string[] digit = { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" };
        int ind1 = 0;
        for (int i = 0; i < digit.Length; i++)
        {
            ind1 = msg.IndexOf(digit[i]);
            if (ind1 != -1)
            {
                return ind1;
            }
        }
        return 1001;
    }
}