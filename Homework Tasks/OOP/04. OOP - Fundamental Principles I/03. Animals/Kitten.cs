using System;

namespace Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = Animals.Gender.Female;
        }
    }
}
