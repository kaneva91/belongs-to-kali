using System;
using System.Linq;
using System.Text;

namespace DefiningClassesPart2
{
    class GenericList<T>
    {
        private T[] elements;
        private const int InitialCapacity = 4;

        public GenericList()
        {
            this.elements = new T[InitialCapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return elements.Length;
            }
        }

        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Expand(elements);
            }
            elements[this.Count] = element;
            Count++;
        }

        public T AccessByIndex(int index)
        {
            return this.elements[index];
        }

        public void RemoveByIndex(int index)
        {
            if (index > this.Count)
            {
                throw new ArgumentException("Index not found.Index may be out of range!!!");
            }

            for (int i = index; i < this.elements.Length - 1; i++)
            {
                elements[index] = elements[index + 1];
            }
            Count--;
        }

        public void Insert(T item, int position)
        {
            if (this.Count + 1 == this.Capacity)
            {
                this.Expand(elements);
            }
            Count++;
            var newElements = new T[this.Count];

            for (int i = 0; i < position; i++)
            {
                newElements[i] = elements[i];
            }

            newElements[position] = item;

            for (int i = position + 1; i < newElements.Length; i++)
            {
                newElements[i] = elements[i - 1];
            }

            this.elements = newElements;
        }

        public void Clear()
        {
            var newElements = new T[InitialCapacity];
            this.elements = newElements;
        }

        public int FindValue(T value)
        {
            var index = Array.IndexOf(this.elements, value);
            return index;
        }

        public T Min()
        {
            var value =  this.elements.Min();
            return value;
        }

        public T Max()
        {
            var value = this.elements.Max();
            return value;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                output.Append(this.elements[i] + " ");
            }
            return output.ToString();
        }

        private void Expand(T[] elements)
        {
            var newElements = new T[2 * this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }
    }
}
