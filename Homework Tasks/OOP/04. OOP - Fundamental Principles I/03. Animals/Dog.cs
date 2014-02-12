using System;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ProduceSound()
        {
            return "Bau-bau!";
        }

    }
}
