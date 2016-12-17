using System;

class IntDoubleString
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "integer")
        {
            int result = int.Parse(Console.ReadLine());
            Console.WriteLine(result + 1);
        }
        else if (input == "real")
        {
            double result = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", result + 1);
        }
        else if (input == "text")
        {
            string result = Console.ReadLine();
            Console.WriteLine(result + "*");
        }
    }
}
