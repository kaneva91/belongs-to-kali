using System;
using System.Text;

namespace _02StudentsAdWokers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (grade < 2.00 && grade > 6.00)
                {
                    throw new ArgumentException("Grade must match the six-point grading system!");
                }
                this.grade = value;
            }
        }

        public override string ConsoleLog()
        {
            var student = new StringBuilder();
            student.Append(base.ConsoleLog());
            student.AppendLine("Grade: " + this.Grade);
            return student.ToString();
        }
            
    }
}
