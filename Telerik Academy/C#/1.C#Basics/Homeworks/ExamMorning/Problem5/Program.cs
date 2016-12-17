using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n / 100;
        int b = (n / 10) % 10;
        int c = n % 10;
        double output = double.MinValue;
        if (c == 0)
        {
            Console.WriteLine("{0:f2}", a * b);
        }
        else if (c > 0)
        {
            if (c <= 5)
            {
                output = a * b;
                Console.WriteLine("{0:f2}", output / c);
            }
            else
            {
                output = a + b;
                Console.WriteLine("{0:f2}", output * c);
            }
        }
        //Console.WriteLine(output);
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
    }
    
}
