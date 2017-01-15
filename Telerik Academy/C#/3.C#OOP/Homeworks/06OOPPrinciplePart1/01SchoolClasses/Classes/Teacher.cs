using System.Collections.Generic;

namespace _01SchoolClasses.Classes
{
    class Teacher : Person
    {
        List<Discipline> setOfDisciplines = new List<Discipline>();
        
        public Teacher(string name, List<Discipline> setOfDisciplines) : base(name)
        {
            this.SetOfDisciplines = setOfDisciplines;
        }

        public List<Discipline> SetOfDisciplines
        {
            get
            {
                return setOfDisciplines;
            }
            private set
            {
                this.SetOfDisciplines = value;
            }
        }
            public string TextBlock { get; set; }
    }
}
