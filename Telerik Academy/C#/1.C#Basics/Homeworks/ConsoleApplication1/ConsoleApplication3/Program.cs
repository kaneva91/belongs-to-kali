using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] path = input.ToCharArray();
        int p = (int)Char.GetNumericValue(path[0]);

        //int p =  Math.Abs(48 - (int)path[0]);
        bool jumps = true;
        while (jumps)
        {
            if (p > path.Length )
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", p);
               
                break;
            }
            else if (p < 0)
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", p);
              
                break;
            }
            else if (path[p] == '^')
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", p);
                jumps = false;
            }
            else if (path[p] == '0')
            {
                Console.WriteLine("Too drunk to go on after {0}!", p);
                jumps = false;
            }
           
            int currpos = (int)Char.GetNumericValue(path[p]);
            if (currpos % 2 == 0)
            {
                p += currpos;
            }
            else
            {
                p -= currpos;
            }           
            //Console.WriteLine(p);
        }
    }
}
