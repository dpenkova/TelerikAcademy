/* Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0. */

using System;

class FindingTheThirdBit
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int myNumber = Int32.Parse(Console.ReadLine());
        
        int mask = 1 << 3;
        int myNumAndMask = myNumber & mask;

        int thirdBit = myNumAndMask >> 3;

        Console.WriteLine("\nThe third bit (counting from 0) of your number is: {0}.\n", thirdBit);
        

    }
}

