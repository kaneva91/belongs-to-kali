using System;

namespace Homework
{
    public class GSMCallHistoryTest
    {
        public static void GSMCallHistoryTestPrint()
        {
            GSM cellPhoneTest = new GSM("IPhone 7", "Apple", 6788888, "GipsyKing", new Battery("Non-removable", 25.34, 1.39, BatteryType.LiIon), new Display(4.7, 1000000));
            Call firstCall = new Call(cellPhoneTest, DateTime.Now, "0899556448", 5600);
            cellPhoneTest.AddCallHistory(firstCall);
            Call secondCall = new Call(cellPhoneTest, DateTime.Now, "0876050548", 200);
            cellPhoneTest.AddCallHistory(secondCall);
            Call thirdCall = new Call(cellPhoneTest, DateTime.Now, "0876980549", 250);
            cellPhoneTest.AddCallHistory(thirdCall);

            cellPhoneTest.PrintCallHistory();
            cellPhoneTest.CallPrice();
            cellPhoneTest.RemoveLongestCall();
            Console.WriteLine("\nThe longest call was removed...\n");
            cellPhoneTest.CallPrice();
            cellPhoneTest.ClearCallHistory();
            cellPhoneTest.PrintCallHistory();
            Console.WriteLine();
        } 
    }
}
