using System;

namespace Shapes
{
    abstract class Shape
    {
        private double width;
        private double height;

        protected double Width
        {
            get {return this.width;}
            set
            {
                if (value <= 0 )
	            {
                    throw new ArgumentException("Shape can not have negative or null dimensions.");
	            }

                this.width = value;
            }
        }

        protected double Height
        {
            get {return this.height;}
            set
            {
                if (value <= 0 )
	            {
                    throw new ArgumentException("Shape can not have negative or null dimensions.");
	            }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
        
    }
}
