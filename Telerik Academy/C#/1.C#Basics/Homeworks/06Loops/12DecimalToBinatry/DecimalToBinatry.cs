using System;
using System.Linq;

class DecimalToBinatry
{
    static void Main()
    {
        int decNum = int.Parse(Console.ReadLine());
        string binary = null;
        while (decNum > 0)
        {
            if (decNum % 2 == 0)
            {
                binary += "0";
            }
            else
            {
                binary += "1";
            }
            decNum = decNum / 2;
        }
        string output = new string(binary.ToCharArray().Reverse().ToArray());
        Console.WriteLine(output);
    }
}
