using System;

class MultiplicationSign
{
    static void Main()
    {
        double multiplication = 1;
        for (int i = 1; i <=3; i++)
        {
            multiplication *= double.Parse(Console.ReadLine());
        }
        if (multiplication == 0)
        {
            Console.WriteLine(0);
        }
        else if (multiplication > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
