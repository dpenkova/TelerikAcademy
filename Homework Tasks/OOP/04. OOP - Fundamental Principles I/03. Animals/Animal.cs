using System;

namespace Animals
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;

        public Gender Gender { get; protected set; }

        public int Age 
        {
            get { return this.age; }
            protected set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid age. Animal age should be positive.");
                }

                this.age = value;
            }
        }

        public string Name 
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Animal name cannot be empty or white space.");
                }

                this.name = value;
            }
        
        }

        public abstract string ProduceSound();
    }
}
