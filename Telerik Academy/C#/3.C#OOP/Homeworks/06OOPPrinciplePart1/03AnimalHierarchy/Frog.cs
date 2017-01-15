using System;

namespace _03AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, double age, GenderType gender) : base(name, age, gender)
        {
        }

        public override void PlaySound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}
