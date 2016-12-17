using System;
// The aim is to count zeros without calculating factorial
class Trailing0InNFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        while (n >= 5)
        {
            n = n / 5;
            counter += n;
        }
        Console.WriteLine(counter);
    }
}
