/* Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. 
 * Example: v=5; p=1 -> false. */

using System;

class BitAtPositionP
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int intNumV = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the searched byte (integer): ");
        int positionP = int.Parse(Console.ReadLine()); ;

        int mask = 1 << positionP;
        int intNumVAndMask = intNumV & mask;
        int bitAtP = intNumVAndMask >> positionP;

        bool result = (bitAtP == 1);

        Console.WriteLine("\nThe bit at the position {0} of your integer ({1}) is '1': {2}.\n", positionP, intNumV, result);

    }
}

