using System;
using System.Collections.Generic;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            List<string> code = new List<string>();
            string input = Console.ReadLine();
            string decoded = null;
            string text = null;
            while (input != "end")
            {
                code.Add(input);
                input = Console.ReadLine();
            }
            for (int i = 0; i < code.Count; i++)
            {
                text = code[i];
                if (l >= 0)
                {
                    if (s > 0)
                    {
                        if (l > text.Length)
                        {
                            continue;
                        }
                        else
                        {
                            while (l < text.Length)
                            {
                                decoded += text[l];
                                l += s;
                            }

                        }
                    }
                    else if (s < 0)
                    {

                    }
                }
                  
                   
                else if (l < 0)
                {
                    l = Math.Abs(l);
                    while (l > 0)
                    {
                        decoded += text[text.Length - l];
                        l -= s;
                    }
                    
                    


                }
                
            }
            Console.WriteLine(decoded);
        }
    }
}
