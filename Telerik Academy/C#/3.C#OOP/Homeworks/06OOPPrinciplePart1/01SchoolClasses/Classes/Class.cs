using System;
using System.Collections.Generic;
using _01SchoolClasses.Interfaces;

namespace _01SchoolClasses.Classes
{
    class Class : ICommentable
    {
        private string textID;
        private List<Teacher> setOfTeachers = new List<Teacher>();
        private string textBLock;

        public Class(string textID, List<Teacher> setOfTeachers)
        {
            this.TextID = textID;
            this.SetOfTeachers = setOfTeachers;
        }

        public string TextID
        {
            get
            {
                return this.textID;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid class ID!");
                }
                this.textID = value;
            }
        }

        public List<Teacher> SetOfTeachers { get; private set; }

        public void AddTextBlock(string text)
        {
            if (text.Length < 5 || string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Comments cannot be less than symbols!");
            }
            this.textBLock = text;
        }

        public string DisplayTextBlock()
        {
            return this.textBLock;
        }
    }
}
