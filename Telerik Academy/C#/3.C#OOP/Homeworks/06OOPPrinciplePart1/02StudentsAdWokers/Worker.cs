using System;
using System.Text;

namespace _02StudentsAdWokers
{
    class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary cannot be less than zero!");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours per day cannot be less than zero!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour(decimal weekSalary, double workHoursPerDay)
        {   // Accept that one weeek has 5 working days
            var moneyPerHour = (weekSalary / 5) / (decimal)workHoursPerDay;
            return moneyPerHour;
        }

        public override string ConsoleLog()
        {
            var worker = new StringBuilder();
            worker.Append(base.ConsoleLog());
            worker.AppendLine("Week salary: " + this.weekSalary);
            worker.AppendLine("Work hours per day: " + workHoursPerDay);
            return base.ConsoleLog();
        }
    }
}
