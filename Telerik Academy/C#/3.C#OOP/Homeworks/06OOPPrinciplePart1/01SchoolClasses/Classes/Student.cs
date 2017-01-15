using System;

namespace _01SchoolClasses.Classes
{
    class Student : Person
    {
        int classNumber;
        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Student's class number cannot be less or equal to zero!");
                }
                this.classNumber = value;
            }
        }
    }
}
