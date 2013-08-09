/* Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender. */

using System;

class BoolIsFemale
{
    static void Main()
    {
        bool isFemale = true;
        Console.WriteLine("The statement: \"I'm a female\" is {0}\n", isFemale);

        // Reading from the console

        bool isFemaleTwo;
        Console.Write("Write down your gender (Male/Female): ");
        string gender = Console.ReadLine();

        if (gender == "Male")
        {
            isFemaleTwo = false;
            Console.WriteLine("The statement: \" I'm a female\" is: {0}\n", isFemaleTwo);
        }

        else
        {
            isFemaleTwo = true;
            Console.WriteLine("The statement: \" I'm a female\" is: {0}\n", isFemaleTwo);
        }
    }
}

