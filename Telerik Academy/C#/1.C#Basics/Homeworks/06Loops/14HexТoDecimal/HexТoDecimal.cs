using System;

class HexТoDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long decNum = 0;
        int power = 0;
        int current = 0;
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            switch (hex[i])
            {
                case '0':
                    current = 0;
                    break;
                case '1':
                    current = 1;
                    break;
                case '2':
                    current = 2;
                    break;
                case '3':
                    current = 3;
                    break;
                case '4':
                    current = 4;
                    break;
                case '5':
                    current = 5;
                    break;
                case '6':
                    current = 6;
                    break;
                case '7':
                    current = 7;
                    break;
                case '8':
                    current = 8;
                    break;
                case '9':
                    current = 9;
                    break;
                case 'A':
                    current = 10;
                    break;
                case 'B':
                    current = 11;
                    break;
                case'C':
                    current = 12;
                    break;
                case 'D':
                    current = 13;
                    break;
                case 'E':
                    current = 14;
                    break;
                case 'F':
                    current = 15;
                    break;
            }
            decNum +=(long)(current * Math.Pow(16, power));
            power++;
        }
        Console.WriteLine(decNum);
    }
}
