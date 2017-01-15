using System;

namespace _03AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat(string name, double age, GenderType gender) : base(name, age, gender)
        {
        }

        public override void PlaySound()
        {
            Console.WriteLine("Meo - meo!");
        }
    }
}
