using _01SchoolClasses.Interfaces;
using System;
using System.Linq;

namespace _01SchoolClasses.Classes
{
    class Person : IName, ICommentable
    {
        private string name;
        private string textBlock;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Person's name cannot be empty!");
                }
                this.name = value;
            }


        }

        public void AddTextBlock(string text)
        {
            if (text.Length < 5)
            {
                throw new ArgumentException("Comments cannot be less than symbols!");
            }
            this.textBlock = text;
        }

        public string DisplayTextBlock()
        {
            return this.textBlock;
        }      
    }
}
