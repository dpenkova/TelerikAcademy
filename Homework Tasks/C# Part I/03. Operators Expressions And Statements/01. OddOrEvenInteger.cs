/* Write an expression that checks if given integer is odd or even. */

using System;

class OddOrEvenInteger
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int myNumber = Int32.Parse(Console.ReadLine());
        
        bool result = (myNumber % 2 == 0);
        
        if (result == true)
        {
            Console.WriteLine("The number you entered is: even.\n");
        }

        else
        {
            Console.WriteLine("The number you entered is: odd.\n");
        }
    }
}

