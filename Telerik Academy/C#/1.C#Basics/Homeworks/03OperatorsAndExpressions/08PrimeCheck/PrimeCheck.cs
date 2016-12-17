using System;

class PrimeCheck
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        bool result = true;
        if (input <= 0)
        {
           result = false;
        }
        else if (input == 1)
        {
            result = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    result = false;
                    break;
                }
            }
        }
        if (result)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
