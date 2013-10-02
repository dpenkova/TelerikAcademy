using System;
using System.Linq;
using System.Text;

namespace ClassMobilePhone
{
    public class Display
    {
        // Fields

        private double? size;  // Display size in inches
        private int? numberOfColors;

        // Constructors - task 2
        // Define several constructors for the defined classes that take different sets of arguments
        // (the full information for the class or part of it). Assume that model and manufacturer are mandatory
        // (the others are optional). All unknown data fill with null.

        // Constructors
        public Display() : this(null, null)
        {
 
        }

        public Display(double? size) : this(size, null)
        {
           
        }

        public Display(double? size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        // Properties - Task 5
        // Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        // Ensure all fields hold correct data at any given time.

        public double? Size
        {
            get { return this.size; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display size cannot be zero or negative.");
                }
                else
                {
                    this.size = value;                
                }
            }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Colors cannot be zero or negative.");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder fullDisplayInfo = new StringBuilder();

            fullDisplayInfo.AppendFormat("\nSize : {0}{1}\nColors: {2}", this.Size, this.Size == null ? "": "\"",this.NumberOfColors);

            return fullDisplayInfo.ToString();
        }
    }
}
