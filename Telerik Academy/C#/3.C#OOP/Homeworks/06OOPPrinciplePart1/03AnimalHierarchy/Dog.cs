using System;

namespace _03AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog(string name, double age, GenderType gender) : base(name, age, gender)
        {
        }

        public override void PlaySound()
        {
            Console.WriteLine("Wow - wow!");
        }
    }
}
