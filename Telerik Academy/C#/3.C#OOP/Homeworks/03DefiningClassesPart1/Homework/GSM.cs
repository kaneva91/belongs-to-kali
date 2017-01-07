using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class GSM
    {
        // Fields
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery batteryInfo;
        private Display displayInfo;
        private List<Call> callHistory = new List<Call>();
        public static readonly GSM iphone4s = new GSM("Iphone 4S", "Apple", 9999, "Someone Else", new Battery("Non-removable", 45.23, 2.78, BatteryType.LiIon), new Display(6.2, 10000));
        // Constructors
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery batteryInfo, Display displayInfo)
            : this(model, manufacturer, price, owner)
        {
            this.BatteryInfo = batteryInfo;
            this.DisplayInfo = displayInfo;
        }
        // Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid model name!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid manufacturer name!");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be less than 0!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid or emply owner name!");
                }
                this.owner = value;
            }
        }

        public Battery BatteryInfo
        {
            get
            {
                return this.batteryInfo;
            }
            set
            {
                this.batteryInfo = value;
            }
        }

        public Display DisplayInfo
        {
            get
            {
                return this.displayInfo;
            }
            set
            {
                this.displayInfo = value;
            }
        }

        public static GSM IPhone4s
        {
            get
            {
                return iphone4s;
            }
            set
            {
                throw new ArgumentException("Invalid data for IPhone 4s!");
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        //ToString() method
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            if (model != null)
            {
                output.AppendLine("Model:" + model);
            }
            if (manufacturer != null)
            {
                output.AppendLine("Manifacturer:" + manufacturer);
            }
            if (price != null)
            {
                output.AppendLine("Price $:" + price);
            }
            if (owner != null)
            {
                output.AppendLine("Owner: " + owner);
            }
            if (batteryInfo.Model != null)
            {
                output.AppendLine("Battery model: " + batteryInfo.Model);
            }
            if (batteryInfo.HoursIdle != null)
            {
                output.AppendLine("\tHours idle: " + batteryInfo.HoursIdle);
            }
            if (batteryInfo.HoursTalk != null)
            {
                output.AppendLine("\tHours talk: " + batteryInfo.HoursTalk);
            }

            output.AppendLine("BateryType: " + batteryInfo.Type);

            if (displayInfo.Size != null)
            {
                output.AppendLine("Display size: " + displayInfo.Size);
            }
            if (displayInfo.NumberOfColors != null)
            {
                output.AppendLine("Number of colors: " + displayInfo.NumberOfColors);
            }
            output.AppendLine("----------------------");
            return output.ToString();
        }

        // Methods
        public void AddCallHistory(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
            Console.WriteLine("Call history cleared!!!");
        }

        public void PrintCallHistory()
        {
            foreach (var item in this.CallHistory)
            {
                Console.WriteLine(item);
            }
        }

        public void CallPrice()
        {
            double sum = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                sum += (this.CallHistory[i].Duration / 60) * 0.37;
            }

            Console.WriteLine("The Total price is {0:F2} lv", sum);
        }

        public void RemoveLongestCall()
        {
            double max = 0;
            int ind = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (this.callHistory[i].Duration >= max)
                {
                    max = this.callHistory[i].Duration;
                    ind = i;
                }
            }
            this.callHistory.Remove(callHistory[ind]);
        }
    }
}
