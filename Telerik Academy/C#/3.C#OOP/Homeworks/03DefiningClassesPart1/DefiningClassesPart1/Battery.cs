using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Battery
    {   //Fields
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;
        //Constructors
        public Battery()
        {

        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, double hoursIdle)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
            :this(model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
            : this(model, hoursIdle, hoursTalk)
        {
            this.Type = type;
        }
        //Properties
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
                    throw new ArgumentException("Invalid battery model name!");
                }
                this.model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Idle cannot be less than 0!");
                }
                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Talk cannot be less than 0!");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
    }  
}
