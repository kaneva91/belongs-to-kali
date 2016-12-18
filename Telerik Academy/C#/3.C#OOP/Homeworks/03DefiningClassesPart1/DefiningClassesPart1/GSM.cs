using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class GSM
    {   // Fields
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery batteryInfo;
        private Display displayInfo;
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
        { get
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
        { get
            {
                return this.displayInfo;
            }
            set
            {
                this.displayInfo = value;
            }
        }
    }
}
