using System;

namespace _03AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string name, double age, GenderType gender) : base(name, age, gender)
        {
        }

        public override GenderType Gender
        {
            get
            {
                return base.Gender;
            }
            set
            {
                if (value == GenderType.Female)
                {
                    throw new ArgumentException("Tomcats must be male!");
                }
                base.Gender = value;
            }
        }
    }
}
