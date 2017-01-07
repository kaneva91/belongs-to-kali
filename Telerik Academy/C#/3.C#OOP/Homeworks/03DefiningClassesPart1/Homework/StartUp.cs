using System;

namespace Homework
{
    class StartUp
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("IPhone 6S", "Apple", 100000, "Me", new Battery("Non-removable", 25.34, 1.39, BatteryType.LiIon), new Display(4.7, 1000000));
            Console.WriteLine(gsm.ToString());
            GSMTest.PrintCellPhoneArray();
            GSMTest.PrintIPhone4S();
            Console.WriteLine("Call Hisory:");
            GSMCallHistoryTest.GSMCallHistoryTestPrint();
        }
    }
}
