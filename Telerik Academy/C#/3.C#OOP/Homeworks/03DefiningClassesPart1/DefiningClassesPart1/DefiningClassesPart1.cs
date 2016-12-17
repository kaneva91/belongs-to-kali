using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class DefiningClassesPart1
    {
        static void Main(string[] args)
        {
            BatteryType battType = new BatteryType();
            Battery gsmBatety = new Battery("Non-removable", 25.34, 1.39,battType);
            Display gsmDisplay = new Display(4.7, 1000000);
            GSM gsm = new GSM("IPhone 6S", "Apple", 100000, "Me", gsmBatety, gsmDisplay);
        }
    }
}
