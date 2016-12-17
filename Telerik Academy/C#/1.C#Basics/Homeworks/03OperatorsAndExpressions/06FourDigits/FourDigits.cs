using System;

class FourDigits
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int a = input / 1000;
        int b = (input % 1000)/100;
        int c = (input % 100)/10;
        int d = input % 10;
        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}",d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}
