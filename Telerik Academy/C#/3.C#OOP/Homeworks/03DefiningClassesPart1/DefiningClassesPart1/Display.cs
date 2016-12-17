using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Display
    {   // Fields
        private double? size;
        private int? numberOfColors;
        // Constructors
        public Display()
        {

        }

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, int numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }
        // Properties
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid size!");
                }
                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of colors!");
                }
                this.numberOfColors = value;
            }
        }
    }
}
