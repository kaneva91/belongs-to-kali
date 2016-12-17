using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        double dec = 0;
        int n = input.Length - 1;
        int current = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '1')
            {
                current = 1;
                dec += current*Math.Pow(2,n);
            }
            else
            {
                current = 0;
                dec += current * Math.Pow(2, n);
            }
            n--;
        }
        Console.WriteLine(dec);
    }
}
