using System;

namespace Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ProduceSound()
        {
            return "Kwa-kwa!";
        }
    }
}
