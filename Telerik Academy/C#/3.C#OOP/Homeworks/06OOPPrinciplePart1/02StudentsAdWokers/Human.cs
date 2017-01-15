using System;
using System.Text;

namespace _02StudentsAdWokers
{
    public abstract class Human 
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid numan firts name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid numan last name!");
                }
                this.lastName = value;
            }
        }

        public virtual string ConsoleLog()
        {
            var human = new StringBuilder();
            human.AppendLine("First name: " + this.firstName);
            human.AppendLine("First name: " + this.lastName);
            return human.ToString();
        }

    }
}
