namespace _03AnimalHierarchy
{
    abstract class Animal : ISound
    {
        private string name;
        private double age;
        private GenderType gender;

        public double Age { get; private set; }
        public string Name { get; private set; }
        public virtual GenderType Gender { get;  set; }

        public Animal(string name, double age, GenderType gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual void PlaySound()
        {
            
        }
    }
}
