using _01SchoolClasses.Interfaces;
using System;

namespace _01SchoolClasses.Classes
{
    class Discipline : IName
    {
        string disciplineName;
        int lecturersNumber;
        int  exercisesNumber;
        
        public Discipline(string disciplineName,int lecturersNumber, int exersisesNumber)
        {
            this.Name = disciplineName;
        }

        public string Name
        {
            get
            {
                return this.disciplineName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid discipline name!");
                }
                this.disciplineName = value;
            }
        }

        public int LecturersNumber
        {
            get
            {
                return this.lecturersNumber;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Lecturers' number cannot be less than zero!");
                }
                this.lecturersNumber = value;
            }
        }

        public int ExercisesNumber
        {
            get
            {
                return this.exercisesNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Exercises number cannot be less than zero!");
                }
                this.exercisesNumber = value;
            }
        }

    }
}
