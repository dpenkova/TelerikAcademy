using System;

namespace Animals
{
    abstract class Cat : Animal
    {
        public override string ProduceSound()
        {
            return "Myauu-myauu!";
        }
    }
}
