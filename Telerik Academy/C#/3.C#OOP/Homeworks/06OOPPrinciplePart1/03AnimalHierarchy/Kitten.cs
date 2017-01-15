using System;

namespace _03AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, double age, GenderType gender) : base(name, age, gender)
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
                if (value == GenderType.Male)
                {
                    throw new ArgumentException("Kittens must be female!");
                }
                base.Gender = value;
            }
        }
    }
}
