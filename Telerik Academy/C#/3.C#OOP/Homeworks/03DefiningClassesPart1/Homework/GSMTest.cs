using System;

namespace Homework
{
    public class GSMTest
    {
        public static void PrintCellPhoneArray()
        {
            GSM[] cellPhones =
            {
           new GSM("3310", "Nokia", 23000, "Penka", new Battery("Non-removable", 45.23, 2.78, BatteryType.LiIon), new Display(6.2, 10000)),
           new GSM("Galaxy S6", "Samsung", 34000, "Haralampi", new Battery("Non-removable", 67.78, 6.54, BatteryType.LiIon), new Display(7.8, 1450000)),
           new GSM("Xperia", "Sony", 34000, "Gruicho", new Battery("Non-removable", 3.01, 2.96, BatteryType.NiCd), new Display(3.5, 156000))
            }; 
            foreach (GSM cellPhone in cellPhones)
            {
                Console.WriteLine(cellPhone.ToString());
            }
        } 
        public static void PrintIPhone4S()
        {
            Console.WriteLine(GSM.iphone4s.ToString());
        }
    }
}
