using System;

class CompareCharArrays
{
    static void Main()
    {  
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string result = "=";
        int length = Math.Min(first.Length, second.Length);

        for (int i = 0; i < length; i++)
        {
            if (first[i] > second[i])
            {
                result = ">";
                break;
            }
            else if (first[i] < second[i])
            {
                result = "<";
                break;
            }
            else
            {
                if (first.Length > second.Length)
                {
                    result = ">";
                    break;
                }
                else if (first.Length < second.Length)
                {
                    result = "<";
                }
            }
        }
        Console.WriteLine(result);      
    }
}
