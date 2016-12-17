using System;

class ThirdBit
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int mask = 1;
        //int result = (input & mask) >> 3;
        int result = ((mask << 3) & input) >> 3;
        Console.WriteLine(result);
    }
}
