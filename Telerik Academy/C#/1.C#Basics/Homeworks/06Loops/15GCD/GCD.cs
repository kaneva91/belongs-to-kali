using System;

class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        int reminder = -1;
       
        if (a == 0 || b == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            if (a < b) // bitwise reversation of a and b
            {
                a = a ^ b;
                b = a ^ b;
                a = a ^ b;
            }
            
            int division = 0;

            while (reminder != 0)
            {
                division = (int)(a / b);
                reminder = a - division * b;
                a = b;
                b = reminder;
                
            }
           
            Console.WriteLine(a);
        }
    }
}